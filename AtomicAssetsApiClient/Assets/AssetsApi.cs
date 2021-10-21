using System;
using System.Net.Http;
using AtomicAssetsApiClient.Core;

namespace AtomicAssetsApiClient.Assets
{
    public class AssetsApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal AssetsApi(string baseUrl) => _requestUriBase = baseUrl;

        public AssetsDto Assets()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AssetsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AssetsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AssetsDto Assets(AssetsUriParameterBuilder assetsUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AssetsUri(assetsUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AssetsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AssetDto Asset(string assetId)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AssetUri(assetId)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AssetDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public StatsDto AssetStats(string assetId)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AssetStatsUri(assetId)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<StatsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto AssetLogs(string assetId)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AssetLogsUri(assetId)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto AssetLogs(string assetId, AssetsUriParameterBuilder assetsUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AssetLogsUri(assetId, assetsUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri AssetsUri() => new Uri($"{_requestUriBase}/assets");
        private Uri AssetsUri(AssetsUriParameterBuilder assetsUriParameterBuilder) => new Uri($"{_requestUriBase}/assets{assetsUriParameterBuilder.Build()}");
        private Uri AssetUri(string assetId) => new Uri($"{_requestUriBase}/assets/{assetId}");
        private Uri AssetStatsUri(string assetId) => new Uri($"{_requestUriBase}/assets/{assetId}/stats");
        private Uri AssetLogsUri(string assetId) => new Uri($"{_requestUriBase}/assets/{assetId}/logs");
        private Uri AssetLogsUri(string assetId, AssetsUriParameterBuilder assetsUriParameterBuilder) => new Uri($"{_requestUriBase}/assets/{assetId}/logs{assetsUriParameterBuilder.Build()}");
    }
}