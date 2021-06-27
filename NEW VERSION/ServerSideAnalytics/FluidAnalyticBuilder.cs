﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ServerSideAnalytics
{
    public class FluidAnalyticBuilder
    {
        private readonly IAnalyticStore _store;
        private IGeoIpResolver _geoIp;
        private List<Func<HttpContext, bool>> _exclude;

        internal FluidAnalyticBuilder(IAnalyticStore store)
        {
            _store = store;
        }

        internal async Task Run(HttpContext context, Func<Task> next)
        {
            var identity = context.UserIdentity();

            //Pass the command to the next task in the pipeline
            await next.Invoke().ConfigureAwait(false);

            //This request should be filtered out ?
            if (_exclude?.Any(x => x(context)) ?? false)
            {
                return;
            }

            //Let's build our structure with collected data
            var req = new WebRequest
            {
                Timestamp = DateTime.Now,
                Identity = identity,
                RemoteIpAddress = context.Connection.RemoteIpAddress,
                Method = context.Request.Method,
                UserAgent = context.Request.Headers["User-Agent"],
                Path = context.Request.Path.Value,
                IsWebSocket = context.WebSockets.IsWebSocketRequest,

                //Ask the store to resolve the geo code of given ip address 
                CountryCode = _geoIp != null
                               ? await _geoIp.ResolveCountryCodeAsync(context.Connection.RemoteIpAddress).ConfigureAwait(true)
                               : CountryCode.World

            };

            //Store the request into the store
            await _store.StoreWebRequestAsync(req).ConfigureAwait(false);
        }

        public FluidAnalyticBuilder UseGeoIpResolver(IGeoIpResolver geoIp)
        {
            _geoIp = geoIp;
            return this;
        }

        public FluidAnalyticBuilder Exclude(Func<HttpContext, bool> filter)
        {
            if(_exclude == null) _exclude = new List<Func<HttpContext, bool>>();
            _exclude.Add(filter);
            return this;
        }

        public FluidAnalyticBuilder Exclude(IPAddress ip) => Exclude(x => Equals(x.Connection.RemoteIpAddress, ip));

        public FluidAnalyticBuilder LimitToPath(string path) => Exclude(x => !Equals(x.Request.Path.StartsWithSegments(path, StringComparison.InvariantCulture)));

        public FluidAnalyticBuilder ExcludePath(params string[] paths)
        {
            return Exclude(x => paths.Any(path => x.Request.Path.StartsWithSegments(path, StringComparison.InvariantCulture)));
        }

        public FluidAnalyticBuilder ExcludeExtension(params string[] extensions)
        {
            return Exclude(x => extensions.Any(ext => x.Request.Path.Value.EndsWith(ext, StringComparison.InvariantCulture)));
        }

        public FluidAnalyticBuilder ExcludeLoopBack() => Exclude(x => IPAddress.IsLoopback(x.Connection.RemoteIpAddress));

        public FluidAnalyticBuilder ExcludeIp(IPAddress address) => Exclude(x => x.Connection.RemoteIpAddress.Equals(address));

        public FluidAnalyticBuilder ExcludeStatusCodes(params HttpStatusCode[] codes) => Exclude(context => codes.Contains((HttpStatusCode)context.Response.StatusCode));

        public FluidAnalyticBuilder ExcludeStatusCodes(params int[] codes) => Exclude(context => codes.Contains(context.Response.StatusCode));

        public FluidAnalyticBuilder LimitToStatusCodes(params HttpStatusCode[] codes) => Exclude(context => !codes.Contains((HttpStatusCode)context.Response.StatusCode));

        public FluidAnalyticBuilder LimitToStatusCodes(params int[] codes) => Exclude(context => !codes.Contains(context.Response.StatusCode));
    }
}