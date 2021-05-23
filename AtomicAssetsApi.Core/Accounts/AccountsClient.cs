using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtomicAssetsApi.Core.Accounts
{
    public class AccountsClient
    {
        private string _baseUrl = "https://wax.api.atomicassets.io/atomicassets";
        private IHttpHandler _httpHandler;

        public AccountsClient(IHttpHandler httpHandler, string baseUrl = null)
        {
            _httpHandler = httpHandler;
            if (baseUrl != null)
                _baseUrl = baseUrl;
        }

        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get accounts which own atomicassets NFTs</summary>
        /// <param name="match">Search for partial account name</param>
        /// <param name="collectionName">Filter for specific collection</param>
        /// <param name="schemaName">Filter for specific schema</param>
        /// <param name="templateId">Filter for specific template</param>
        /// <param name="hideOffers">Hide assets which are used in an offer</param>
        /// <param name="hideSales">Hide assets which are listed on a atomicmarket contract which is connected to the API</param>
        /// <param name="collectionBlacklist">Hide collections from result. Split multiple with ","</param>
        /// <param name="collectionWhitelist">Show only results from specific collections. Split multiple with ","</param>
        /// <param name="ids">seperate multiple ids with ","</param>
        /// <param name="lowerBound">lower bound of primary key (value included)</param>
        /// <param name="upperBound">upper bound of primary key (value excluded)</param>
        /// <param name="page">Result Page</param>
        /// <param name="limit">Results per Page</param>
        /// <param name="order">Order direction</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetAccountsResponse> GetAccountsAsync(string match = null, string collectionName = null, string schemaName = null, string templateId = null, bool? hideOffers = null, bool? hideSales = null, string collectionBlacklist = null, string collectionWhitelist = null, string ids = null, string lowerBound = null, string upperBound = null, int? page = null, int? limit = null, Order? order = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/accounts?");
            if (match != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("match") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(match, CultureInfo.InvariantCulture))).Append("&");
            }
            if (collectionName != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("collection_name") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(collectionName, CultureInfo.InvariantCulture))).Append("&");
            }
            if (schemaName != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("schema_name") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(schemaName, CultureInfo.InvariantCulture))).Append("&");
            }
            if (templateId != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("template_id") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(templateId, CultureInfo.InvariantCulture))).Append("&");
            }
            if (hideOffers != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("hide_offers") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(hideOffers, CultureInfo.InvariantCulture))).Append("&");
            }
            if (hideSales != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("hide_sales") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(hideSales, CultureInfo.InvariantCulture))).Append("&");
            }
            if (collectionBlacklist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("collection_blacklist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(collectionBlacklist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (collectionWhitelist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("collection_whitelist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(collectionWhitelist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (ids != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("ids") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(ids, CultureInfo.InvariantCulture))).Append("&");
            }
            if (lowerBound != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("lower_bound") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(lowerBound, CultureInfo.InvariantCulture))).Append("&");
            }
            if (upperBound != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("upper_bound") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(upperBound, CultureInfo.InvariantCulture))).Append("&");
            }
            if (page != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(page, CultureInfo.InvariantCulture))).Append("&");
            }
            if (limit != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("limit") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(limit, CultureInfo.InvariantCulture))).Append("&");
            }
            if (order != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("order") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(order, CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;

            return await _httpHandler.GetAsync<GetAccountsResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get a specific account</summary>
        /// <param name="account">Account name</param>
        /// <param name="hideOffers">Hide assets which are used in an offer</param>
        /// <param name="hideSales">Hide assets which are listed on a atomicmarket contract which is connected to the API</param>
        /// <param name="collectionBlacklist">Hide collections from result. Split multiple with ","</param>
        /// <param name="collectionWhitelist">Show only results from specific collections. Split multiple with ","</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetAccountsResponse> GetAccountsAsync(string account, bool? hideOffers = null, bool? hideSales = null, string collectionBlacklist = null, string collectionWhitelist = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (account == null)
                throw new ArgumentNullException("account");

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/accounts/{account}?");
            urlBuilder.Replace("{account}", Uri.EscapeDataString(Utils.ConvertToString(account, CultureInfo.InvariantCulture)));
            if (hideOffers != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("hide_offers") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(hideOffers, CultureInfo.InvariantCulture))).Append("&");
            }
            if (hideSales != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("hide_sales") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(hideSales, CultureInfo.InvariantCulture))).Append("&");
            }
            if (collectionBlacklist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("collection_blacklist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(collectionBlacklist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (collectionWhitelist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("collection_whitelist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(collectionWhitelist, CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;

            return await _httpHandler.GetAsync<GetAccountsResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get templates and schemas count by account</summary>
        /// <param name="account">Account name</param>
        /// <param name="collectionName">Collection Name</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetAccountsByCollectionResponse> GetAccountsAsync(string account, string collectionName, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (account == null)
                throw new ArgumentNullException("account");

            if (collectionName == null)
                throw new ArgumentNullException("collectionName");

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/accounts/{account}/{collection_name}");
            urlBuilder.Replace("{account}", Uri.EscapeDataString(Utils.ConvertToString(account, CultureInfo.InvariantCulture)));
            urlBuilder.Replace("{collection_name}", Uri.EscapeDataString(Utils.ConvertToString(collectionName, CultureInfo.InvariantCulture)));

            return await _httpHandler.GetAsync<GetAccountsByCollectionResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);
        }

    }
}
