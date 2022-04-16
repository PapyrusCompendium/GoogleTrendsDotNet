using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace GoogleTrends.Extensions {
    public static class HttpResponseMessageExtensions {
        internal const string JSON_REPLACE_STRING = ")]}'\n";
        public static TType As<TType>(this HttpResponseMessage httpResponseMessage) {
            if (httpResponseMessage.IsSuccessStatusCode) {
                using var streamReader = new StreamReader(httpResponseMessage.Content.ReadAsStream());

                var responseContent = streamReader.ReadToEnd().Replace(JSON_REPLACE_STRING, string.Empty);
                return JsonConvert.DeserializeObject<TType>(responseContent);
            }

            return default;
        }

        public static async Task<TType> AsAsync<TType>(this HttpResponseMessage httpResponseMessage) {
            if (httpResponseMessage.IsSuccessStatusCode) {
                var responseJson = (await httpResponseMessage.Content.ReadAsStringAsync()).Replace(JSON_REPLACE_STRING, string.Empty);
                return JsonConvert.DeserializeObject<TType>(responseJson);
            }

            return default;
        }
    }
}

/*  
 *  It would seem that google is just string replacing these out of their API responses in their js client.
 *  I still have no idea why they append these in their Json responses.
 *  For now I'll just replicate the js behavior.
 *  
 *      Google Source
 *      https://ssl.gstatic.com/trends_nrtr/2884_RC01/trends.js
 */


/* Unsure
 *  try {
        var g = JSON.stringify(e.getResponseJson(")]}'\n"));
 */

/* Getting Api Response.
    try {
        var c = JSON.parse(a.replace(")]}'\n", ""));
        b = new fn(c)
    } catch (e) {
        (a = this.logger) && Bk(a, pk, "Response parse failed: " + e.toString(), void 0)
    }
*/