using System.Net;
using System.Numerics;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace ServerSideAnalytics
{
    public static class ServerSideExtensions
    {
        const string cookieName = "SSA_Identity";
        private const string StrFormat = "000000000000000000000000000000000000000";

        public static string UserIdentity(this HttpContext context)
        {
            string identity = context.User?.Identity?.Name;

            if (!context.Request.Cookies.ContainsKey(cookieName))
            {
                if (string.IsNullOrWhiteSpace(identity))
                {
                    identity = context.Request.Cookies.ContainsKey("ai_user")
                                ? context.Request.Cookies["ai_user"]
                                : context.Connection.Id;
                }

                if (!context.Response.HasStarted)
                    context.Response.Cookies.Append("identity", identity);
            }
            else
            {
                identity = context.Request.Cookies[cookieName];
            }

            return identity;
        }

        public static string ToFullDecimalString(this IPAddress ip)
        {
            return (new BigInteger(ip.MapToIPv6().GetAddressBytes().Reverse().ToArray())).ToString(StrFormat);
        }

        public static FluidAnalyticBuilder UseServerSideAnalytics(this IApplicationBuilder app, IAnalyticStore repository)
        {
            var builder = new FluidAnalyticBuilder(repository);
            app.Use(builder.Run);
            return builder;
        }
    }
}
