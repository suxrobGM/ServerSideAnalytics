using System.Net;
using System.Numerics;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace ServerSideAnalytics
{
    public static class ServerSideExtensions
    {
        private const string StrFormat = "000000000000000000000000000000000000000";

        public static string UserIdentity(this HttpContext context)
        {
            var user = context.User?.Identity?.Name;

            const string identityString = "identity";

            var identity = context.Request.Cookies.ContainsKey(identityString)
                ? (string.IsNullOrWhiteSpace(user)
                    ? (context.Request.Cookies.ContainsKey("ai_user")
                        ? context.Request.Cookies["ai_user"]
                        : context.Connection.Id)
                    : user)
                : context.Request.Cookies[identityString];

            context.Response.Cookies.Append("identity",identity);
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
