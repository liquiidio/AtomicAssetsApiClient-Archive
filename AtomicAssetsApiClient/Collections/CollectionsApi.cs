using System;
using System.Net.Http;
using AtomicAssetsApiClient.Core;

namespace AtomicAssetsApiClient.Collections
{
    public class CollectionsApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal CollectionsApi(string baseUrl) => _requestUriBase = baseUrl;

        public CollectionsDto Collections()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public CollectionsDto Collections(CollectionsUriParameterBuilder collectionsUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionsUri(collectionsUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public CollectionDto Collection(string collectionName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionUri(collectionName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<CollectionDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }
 
        public StatsDto CollectionStats(string collectionName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionStatsUri(collectionName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<StatsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto CollectionLogs(string collectionName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionLogsUri(collectionName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto CollectionLogs(string collectionName, CollectionsUriParameterBuilder collectionsUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(CollectionLogsUri(collectionName, collectionsUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri CollectionsUri() => new Uri($"{_requestUriBase}/collections");
        private Uri CollectionsUri(CollectionsUriParameterBuilder collectionsUriParameterBuilder) => new Uri($"{_requestUriBase}/collections{collectionsUriParameterBuilder.Build()}");
        private Uri CollectionUri(string collectionName) => new Uri($"{_requestUriBase}/collections/{collectionName}");
        private Uri CollectionStatsUri(string collectionName) => new Uri($"{_requestUriBase}/collections/{collectionName}/stats");
        private Uri CollectionLogsUri(string collectionName) => new Uri($"{_requestUriBase}/collections/{collectionName}/logs");
        private Uri CollectionLogsUri(string collectionName, CollectionsUriParameterBuilder collectionsUriParameterBuilder) => new Uri($"{_requestUriBase}/collections/{collectionName}/logs{collectionsUriParameterBuilder.Build()}");
    }
}