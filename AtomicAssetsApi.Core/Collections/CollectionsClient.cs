using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtomicAssetsApi.Core.Collections
{
    public class CollectionsClient
    {
        private string _baseUrl = "https://wax.api.atomicassets.io/atomicassets";
        private IHttpHandler _httpHandler;

        public CollectionsClient(IHttpHandler httpHandler, string baseUrl = null)
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
        /// <summary>Fetch collections</summary>
        /// <param name="author">Get collections by author</param>
        /// <param name="match">Search for input in collection name</param>
        /// <param name="authorizedAccount">Filter for collections which the provided account can use to create assets</param>
        /// <param name="notifyAccount">Filter for collections where the provided account is notified</param>
        /// <param name="collectionBlacklist">Hide collections from result. Split multiple with ","</param>
        /// <param name="collectionWhitelist">Show only results from specific collections. Split multiple with ","</param>
        /// <param name="ids">seperate multiple ids with ","</param>
        /// <param name="lowerBound">lower bound of primary key (value included)</param>
        /// <param name="upperBound">upper bound of primary key (value excluded)</param>
        /// <param name="before">Only show results before this timestamp in milliseconds (value excluded)</param>
        /// <param name="after">Only show results after this timestamp in milliseconds (value excluded)</param>
        /// <param name="page">Result Page</param>
        /// <param name="limit">Results per Page</param>
        /// <param name="order">Order direction</param>
        /// <param name="sort">Column to sort</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetCollectionsResponse> GetCollectionsAsync(string author = null, string match = null, string authorizedAccount = null, string notifyAccount = null, string collectionBlacklist = null, string collectionWhitelist = null, string ids = null, string lowerBound = null, string upperBound = null, int? before = null, int? after = null, int? page = null, int? limit = null, Order? order = null, Sort2? sort = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/collections?");
            if (author != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("author") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(author, CultureInfo.InvariantCulture))).Append("&");
            }
            if (match != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("match") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(match, CultureInfo.InvariantCulture))).Append("&");
            }
            if (authorizedAccount != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("authorized_account") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(authorizedAccount, CultureInfo.InvariantCulture))).Append("&");
            }
            if (notifyAccount != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("notify_account") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(notifyAccount, CultureInfo.InvariantCulture))).Append("&");
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
            if (before != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("before") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(before, CultureInfo.InvariantCulture))).Append("&");
            }
            if (after != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("after") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(after, CultureInfo.InvariantCulture))).Append("&");
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
            if (sort != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(sort, CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;

            return await _httpHandler.GetAsync<GetCollectionsResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);

        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Find collection by its name</summary>
        /// <param name="collectionName">Name of collection</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetCollectionResponse> GetCollectionsAsync(string collectionName, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (collectionName == null)
                throw new ArgumentNullException("collectionName");

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/collections/{collection_name}");
            urlBuilder.Replace("{collection_name}", Uri.EscapeDataString(Utils.ConvertToString(collectionName, CultureInfo.InvariantCulture)));

            return await _httpHandler.GetAsync<GetCollectionResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);

        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get stats about collection</summary>
        /// <param name="collectionName">Name of collection</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetCollectionStatsResponse> GetStatsAsync(string collectionName, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (collectionName == null)
                throw new ArgumentNullException("collectionName");

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/collections/{collection_name}/stats");
            urlBuilder.Replace("{collection_name}", Uri.EscapeDataString(Utils.ConvertToString(collectionName, CultureInfo.InvariantCulture)));

            return await _httpHandler.GetAsync<GetCollectionStatsResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Fetch collection logs</summary>
        /// <param name="collectionName">Name of collection</param>
        /// <param name="page">Result Page</param>
        /// <param name="limit">Results per Page</param>
        /// <param name="order">Order direction</param>
        /// <param name="actionWhitelist">Action whitelist</param>
        /// <param name="actionBlacklist">Action blacklist</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetLogsResponse> GetLogsAsync(string collectionName, int? page = null, int? limit = null, Order? order = null, string actionWhitelist = null, int? actionBlacklist = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (collectionName == null)
                throw new ArgumentNullException("collectionName");

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/collections/{collection_name}/logs?");
            urlBuilder.Replace("{collection_name}", Uri.EscapeDataString(Utils.ConvertToString(collectionName, CultureInfo.InvariantCulture)));
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
            if (actionWhitelist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("action_whitelist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(actionWhitelist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (actionBlacklist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("action_blacklist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(actionBlacklist, CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;

            return await _httpHandler.GetAsync<GetLogsResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);

        }
    }
}
