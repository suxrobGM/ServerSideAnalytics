using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ServerSideAnalytics.Extensions
{
    public abstract class ResolverBase
    {
        private static HttpClient Client { get; } = new HttpClient();

        protected static Task<JObject> LoadJson(string uri) => LoadJson(new Uri(uri));

        protected static async Task<JObject> LoadJson(Uri uri)
        {
            var response = await Client.GetStringAsync(uri)
                .ConfigureAwait(true);

            return JsonConvert.DeserializeObject(response) as JObject;
        }
    }
}
