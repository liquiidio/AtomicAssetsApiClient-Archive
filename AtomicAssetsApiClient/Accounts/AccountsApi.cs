using System;
using System.Net.Http;
using AtomicAssetsApiClient.Core;

namespace AtomicAssetsApiClient.Accounts
{
    public class AccountsApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal AccountsApi(string baseUrl) => _requestUriBase = baseUrl;

        public AccountsDto Accounts()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AccountsUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AccountsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AccountsDto Accounts(AccountsUriParameterBuilder accountsUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AccountsUri(accountsUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AccountsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AccountDto Account(string accountName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AccountUri(accountName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AccountDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public AccountCollectionDto Collection(string accountName, string collectionName)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(AccountUri(accountName, collectionName)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<AccountCollectionDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri AccountsUri() => new Uri($"{_requestUriBase}/accounts");
        private Uri AccountsUri(AccountsUriParameterBuilder accountsUriParameterBuilder) => new Uri($"{_requestUriBase}/accounts{accountsUriParameterBuilder.Build()}");
        private Uri AccountUri(string accountName) => new Uri($"{_requestUriBase}/accounts/{accountName}");
        private Uri AccountUri(string accountName, string collectionName) => new Uri($"{_requestUriBase}/accounts/{accountName}/{collectionName}");
    }
}
