using System;
using System.Net.Http;
using AtomicAssetsApiClient.Core;

namespace AtomicAssetsApiClient.Offers
{
    public class OffersApi
    {
        private readonly string _requestUriBase;
        private static readonly HttpClient Client = new HttpClient();

        internal OffersApi(string baseUrl) => _requestUriBase = baseUrl;

        public OffersDto Offers()
        {
            var apiRequest = HttpRequestBuilder.GetRequest(OffersUri()).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<OffersDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public OffersDto Offers(OffersUriParameterBuilder offersUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(OffersUri(offersUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<OffersDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public OfferDto Offer(string offerId)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(OfferUri(offerId)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<OfferDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto OfferLogs(string offerId)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(OfferLogsUri(offerId)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        public LogsDto OfferLogs(string offerId, OffersUriParameterBuilder  schemasUriParameterBuilder)
        {
            var apiRequest = HttpRequestBuilder.GetRequest(OfferLogsUri(offerId, schemasUriParameterBuilder)).Build();
            var apiResponse = Client.SendAsync(apiRequest).Result;
            if (apiResponse.IsSuccessStatusCode)
                return apiResponse.ContentAs<LogsDto>();
            throw new ArgumentException($"An exception has occurred. Status Code: {apiResponse.StatusCode} Error: {apiResponse.Content.ReadAsStringAsync().Result}");
        }

        private Uri OffersUri() => new Uri($"{_requestUriBase}/offers");
        private Uri OffersUri(OffersUriParameterBuilder  offersUriParameterBuilder) => new Uri($"{_requestUriBase}/offers{offersUriParameterBuilder.Build()}");
        private Uri OfferUri(string offerId) => new Uri($"{_requestUriBase}/offers/{offerId}");
        private Uri OfferLogsUri(string offerId) => new Uri($"{_requestUriBase}/offers/{offerId}/logs");
        private Uri OfferLogsUri(string offerId, OffersUriParameterBuilder  offersUriParameterBuilder) => new Uri($"{_requestUriBase}/offers/{offerId}/logs{offersUriParameterBuilder.Build()}");
    }
}