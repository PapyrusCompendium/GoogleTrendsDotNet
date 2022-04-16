using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace GoogleTrends.Extensions {
    public static class HttpResponseMessageExtensions {
        private static readonly Regex _fixJsonRegex = new Regex("^.+{?");
        public static TType As<TType>(this HttpResponseMessage httpResponseMessage, string jsonPath = default) {
            if (httpResponseMessage.IsSuccessStatusCode) {
                using var streamReader = new StreamReader(httpResponseMessage.Content.ReadAsStream());
                var responseContent = streamReader.ReadToEnd();
                responseContent = _fixJsonRegex.Replace(responseContent, string.Empty);

                return SelectJPath<TType>(jsonPath, responseContent);
            }

            return default;
        }

        public static async Task<TType> AsAsync<TType>(this HttpResponseMessage httpResponseMessage, string jsonPath = default) {
            if (httpResponseMessage.IsSuccessStatusCode) {
                var responseContent = (await httpResponseMessage.Content.ReadAsStringAsync());
                responseContent = _fixJsonRegex.Replace(responseContent, string.Empty);

                return SelectJPath<TType>(jsonPath, responseContent);
            }

            return default;
        }

        private static TType SelectJPath<TType>(string jsonPath, string responseContent) {
            var jObject = JObject.Parse(responseContent);

            return string.IsNullOrWhiteSpace(jsonPath)
                ? jObject.ToObject<TType>()
                : jObject.SelectToken(jsonPath).ToObject<TType>();
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