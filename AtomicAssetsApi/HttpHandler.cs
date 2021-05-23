using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AtomicAssetsApi.Core;
using Newtonsoft.Json;

namespace AtomicAssetsApi
{
    public class HttpHandler : IHttpHandler
    {
        private static readonly HttpClient Client = new HttpClient();

        public async Task<TResponseData> GetAsync<TResponseData>(string url, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await Client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            var result = await BuildSendResponse(response);

            var responseData = DeserializeJsonFromStream<TResponseData>(result);

            return responseData;
        }

        /// <summary>
        /// Convert response to stream
        /// </summary>
        /// <param name="response">response object</param>
        /// <returns>Stream with response</returns>
        public async Task<Stream> BuildSendResponse(HttpResponseMessage response)
        {
            var stream = await response.Content.ReadAsStreamAsync();

            if (response.IsSuccessStatusCode)
                return stream;

            var content = await StreamToStringAsync(stream);

            throw new ApiException(response.ReasonPhrase, (int) response.StatusCode, content,
                response.Headers.ToDictionary(h => h.Key, h => h.Value), null);
        }

        /// <summary>
        /// Convert stream to a string
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public async Task<string> StreamToStringAsync(Stream stream)
        {
            string content = null;

            if (stream != null)
                using (var sr = new StreamReader(stream))
                    content = await sr.ReadToEndAsync();

            return content;
        }

        /// <summary>
        /// Generic method to convert a stream with json data to any type
        /// </summary>
        /// <typeparam name="TData">type to convert</typeparam>
        /// <param name="stream">stream with json content</param>
        /// <returns>TData object</returns>
        public TData DeserializeJsonFromStream<TData>(Stream stream)
        {
            if (stream == null || stream.CanRead == false)
                return default;

            using (var sr = new StreamReader(stream))
            using (var jtr = new JsonTextReader(sr))
            {
                return JsonSerializer.Create().Deserialize<TData>(jtr);
            }
        }
    }
}
