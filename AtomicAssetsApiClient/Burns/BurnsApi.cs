using System;
using System.Net.Http;
using AtomicAssetsApiClient.Core;

namespace AtomicAssetsApiClient.Burns
{
    public class BurnsApi
    { 
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal BurnsApi(string baseUrl) => _requestUriBase = baseUrl;

        public BurnsDto Burns()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BurnsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<BurnsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public BurnsDto Burns(BurnsUriParameterBuilder burnsUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BurnsUri(burnsUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<BurnsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public BurnDto Account(string accountName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(BurnUri(accountName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<BurnDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri BurnsUri() => new Uri($"{_requestUriBase}/burns");
        private Uri BurnsUri(BurnsUriParameterBuilder burnsUriParameterBuilder) => new Uri($"{_requestUriBase}/burns{burnsUriParameterBuilder.Build()}");
        private Uri BurnUri(string accountName) => new Uri($"{_requestUriBase}/burns/{accountName}");
    }
}
