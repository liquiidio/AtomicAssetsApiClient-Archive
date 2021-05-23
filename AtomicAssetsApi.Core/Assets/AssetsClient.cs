using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtomicAssetsApi.Core.Assets
{
    public class AssetsClient
    {
        private string _baseUrl = "https://wax.api.atomicassets.io/atomicassets";
        private IHttpHandler _httpHandler;

        public AssetsClient(IHttpHandler httpHandler, string baseUrl = null)
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
        /// <summary>Fetch assets.</summary>
        /// <param name="owner">Filter by owner</param>
        /// <param name="burned">Filter by burned</param>
        /// <param name="collectionName">Filter by collection name</param>
        /// <param name="schemaName">Filter by schema name</param>
        /// <param name="templateId">Filter by template id</param>
        /// <param name="isBurnable">Filter for burnable assets</param>
        /// <param name="match">Search for input in asset name</param>
        /// <param name="isTransferable">Check if asset is transferable</param>
        /// <param name="collectionWhitelist">Show only results from specific collections. Split multiple with ","</param>
        /// <param name="onlyDuplicateTemplates">Show only duplicate assets grouped by template</param>
        /// <param name="authorizedAccount">Filter for assets the provided account can edit.</param>
        /// <param name="hideOffers">Hide assets which are used in an offer</param>
        /// <param name="hideSales">Hide assets which are listed on a atomicmarket contract which is connected to the API</param>
        /// <param name="collectionBlacklist">Hide collections from result. Split multiple with ","</param>
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
        public async Task<GetAssetsResponse> GetAssetsAsync(string owner = null, bool? burned = null, string collectionName = null, string schemaName = null, int? templateId = null, bool? isBurnable = null, string match = null, bool? isTransferable = null, string collectionWhitelist = null, bool? onlyDuplicateTemplates = null, string authorizedAccount = null, bool? hideOffers = null, bool? hideSales = null, string collectionBlacklist = null, string ids = null, string lowerBound = null, string upperBound = null, int? before = null, int? after = null, int? page = null, int? limit = null, Order? order = null, Sort? sort = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/assets?");
            if (owner != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("owner") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(owner, CultureInfo.InvariantCulture))).Append("&");
            }
            if (burned != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("burned") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(burned, CultureInfo.InvariantCulture))).Append("&");
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
            if (isBurnable != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("is_burnable") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(isBurnable, CultureInfo.InvariantCulture))).Append("&");
            }
            if (match != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("match") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(match, CultureInfo.InvariantCulture))).Append("&");
            }
            if (isTransferable != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("is_transferable") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(isTransferable, CultureInfo.InvariantCulture))).Append("&");
            }
            if (collectionWhitelist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("collection_whitelist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(collectionWhitelist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (onlyDuplicateTemplates != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("only_duplicate_templates") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(onlyDuplicateTemplates, CultureInfo.InvariantCulture))).Append("&");
            }
            if (authorizedAccount != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("authorized_account") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(authorizedAccount, CultureInfo.InvariantCulture))).Append("&");
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

            return await _httpHandler.GetAsync<GetAssetsResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Fetch asset by id</summary>
        /// <param name="assetId">ID of asset</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetAssetResponse> GetAssetsAsync(string assetId, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(assetId))
                throw new ArgumentNullException(nameof(assetId));

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/assets/{asset_id}");
            urlBuilder.Replace("{asset_id}", Uri.EscapeDataString(Utils.ConvertToString(assetId, CultureInfo.InvariantCulture)));

            return await _httpHandler.GetAsync<GetAssetResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);

        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Fetch asset stats</summary>
        /// <param name="assetId">ID of asset</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetAssetStatsResponse> GetStatsAsync(int assetId, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (assetId < 0)
                throw new Exception("assetId is smaller than 0");

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/assets/{asset_id}/stats");
            urlBuilder.Replace("{asset_id}", Uri.EscapeDataString(Utils.ConvertToString(assetId, CultureInfo.InvariantCulture)));

            return await _httpHandler.GetAsync<GetAssetStatsResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);

        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Fetch asset logs</summary>
        /// <param name="assetId">ID of asset</param>
        /// <param name="page">Result Page</param>
        /// <param name="limit">Results per Page</param>
        /// <param name="order">Order direction</param>
        /// <param name="actionWhitelist">Action whitelist</param>
        /// <param name="actionBlacklist">Action blacklist</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetLogsResponse> GetLogsAsync(int assetId, int? page = null, int? limit = null, Order? order = null, string actionWhitelist = null, int? actionBlacklist = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (assetId < 0)
                throw new Exception("assetId is smaller than 0");

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/assets/{asset_id}/logs?");
            urlBuilder.Replace("{asset_id}", Uri.EscapeDataString(Utils.ConvertToString(assetId, CultureInfo.InvariantCulture)));
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
