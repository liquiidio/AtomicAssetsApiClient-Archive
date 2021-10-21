using System;
using System.Net.Http;
using AtomicAssetsApiClient.Core;

namespace AtomicAssetsApiClient.Schemas
{
    public class SchemasApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal SchemasApi(string baseUrl) => _requestUriBase = baseUrl;

        public SchemasDto Schemas()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SchemasUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SchemasDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public SchemasDto Schemas(SchemasUriParameterBuilder schemasUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SchemasUri(schemasUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SchemasDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public SchemaDto Schema(string collectionName, string schemaName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SchemaUri(collectionName, schemaName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<SchemaDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public StatsDto SchemaStats(string collectionName, string schemaName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SchemaStatsUri(collectionName, schemaName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<StatsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto SchemaLogs(string collectionName, string schemaName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SchemaLogsUri(collectionName, schemaName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto SchemaLogs(string collectionName, string schemaName, SchemasUriParameterBuilder schemasUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(SchemaLogsUri(collectionName, schemaName, schemasUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri SchemasUri() => new Uri($"{_requestUriBase}/schemas");
        private Uri SchemasUri(SchemasUriParameterBuilder schemasUriParameterBuilder) => new Uri($"{_requestUriBase}/schemas{schemasUriParameterBuilder.Build()}");
        private Uri SchemaUri(string collectionName, string schemaName) => new Uri($"{_requestUriBase}/schemas/{collectionName}/{schemaName}");
        private Uri SchemaStatsUri(string collectionName, string schemaName) => new Uri($"{_requestUriBase}/schemas/{collectionName}/{schemaName}/stats");
        private Uri SchemaLogsUri(string collectionName, string schemaName) => new Uri($"{_requestUriBase}/schemas/{collectionName}/{schemaName}/logs");
        private Uri SchemaLogsUri(string collectionName, string schemaName, SchemasUriParameterBuilder schemasUriParameterBuilder) => new Uri($"{_requestUriBase}/schemas/{collectionName}/{schemaName}/logs{schemasUriParameterBuilder.Build()}");
    }
}