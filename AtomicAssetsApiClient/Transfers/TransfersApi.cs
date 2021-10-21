using System;
using System.Net.Http;
using AtomicAssetsApiClient.Core;

namespace AtomicAssetsApiClient.Transfers
{
    public class TransfersApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal TransfersApi(string baseUrl) => _requestUriBase = baseUrl;

        public TransfersDto Transfers()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TransfersUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TransfersDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public TransfersDto Transfers(TransfersUriParameterBuilder transfersUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(TransfersUri(transfersUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<TransfersDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri TransfersUri() => new Uri($"{_requestUriBase}/transfers");
        private Uri TransfersUri(TransfersUriParameterBuilder transfersUriParameterBuilder) => new Uri($"{_requestUriBase}/transfers{transfersUriParameterBuilder.Build()}");
    }
}