using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtomicAssetsApi.Core.Offers
{
    public class OffersClient
    {
        private string _baseUrl = "https://wax.api.atomicassets.io/atomicassets";
        private IHttpHandler _httpHandler;

        public OffersClient(IHttpHandler httpHandler, string baseUrl = null)
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
        /// <summary>Fetch offers</summary>
        /// <param name="account">Notified account (can be sender or recipient) - separate multiple with ","</param>
        /// <param name="sender">Offer sender - separate multiple with ","</param>
        /// <param name="recipient">Offer recipient - separate multiple with ","</param>
        /// <param name="state">Filter by Offer State (0: PENDING - Offer created and valid, 1: INVALID - Assets are missing because ownership has changed, 2: UNKNOWN - Offer is not valid anymore, 3: ACCEPTED - Offer was accepted, 4: DECLINED - Offer was declined by recipient, 5: CANCELLED - Offer was canceled by sender) - separate multiple with ","</param>
        /// <param name="isRecipientContract">Filter offers where recipient is a contract</param>
        /// <param name="assetId">only offers which contain this asset_id - separate multiple with ","</param>
        /// <param name="templateId">only offers which contain assets of this template - separate multiple with ","</param>
        /// <param name="schemaName">only offers which contain assets of this schema - separate multiple with ","</param>
        /// <param name="collectionName">only offers which contain assets of this collection - separate multiple with ","</param>
        /// <param name="accountWhitelist">Only offers which are sent by one of these accounts</param>
        /// <param name="accountBlacklist">Exclude offers which are sent by one of these accounts</param>
        /// <param name="senderAssetWhitelist">Only offers which contain these assets</param>
        /// <param name="senderAssetBlacklist">Exclude offers which contain these assets</param>
        /// <param name="recipientAssetWhitelist">Only offers which contain these assets</param>
        /// <param name="recipientAssetBlacklist">Exclude offers which contain these assets</param>
        /// <param name="collectionWhitelist">Show only results from specific collections. Split multiple with ","</param>
        /// <param name="page">Result Page</param>
        /// <param name="limit">Results per Page</param>
        /// <param name="order">Order direction</param>
        /// <param name="sort">Column to sort</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetOffersResponse> GetOffersAsync(string account = null, string sender = null, string recipient = null, string state = null, bool? isRecipientContract = null, string assetId = null, string templateId = null, string schemaName = null, string collectionName = null, string accountWhitelist = null, string accountBlacklist = null, string senderAssetWhitelist = null, string senderAssetBlacklist = null, string recipientAssetWhitelist = null, string recipientAssetBlacklist = null, string collectionWhitelist = null, int? page = null, int? limit = null, Order? order = null, Sort5? sort = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/offers?");
            if (account != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("account") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(account, CultureInfo.InvariantCulture))).Append("&");
            }
            if (sender != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("sender") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(sender, CultureInfo.InvariantCulture))).Append("&");
            }
            if (recipient != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("recipient") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(recipient, CultureInfo.InvariantCulture))).Append("&");
            }
            if (state != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("state") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(state, CultureInfo.InvariantCulture))).Append("&");
            }
            if (isRecipientContract != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("is_recipient_contract") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(isRecipientContract, CultureInfo.InvariantCulture))).Append("&");
            }
            if (assetId != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("asset_id") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(assetId, CultureInfo.InvariantCulture))).Append("&");
            }
            if (templateId != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("template_id") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(templateId, CultureInfo.InvariantCulture))).Append("&");
            }
            if (schemaName != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("schema_name") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(schemaName, CultureInfo.InvariantCulture))).Append("&");
            }
            if (collectionName != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("collection_name") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(collectionName, CultureInfo.InvariantCulture))).Append("&");
            }
            if (accountWhitelist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("account_whitelist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(accountWhitelist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (accountBlacklist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("account_blacklist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(accountBlacklist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (senderAssetWhitelist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("sender_asset_whitelist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(senderAssetWhitelist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (senderAssetBlacklist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("sender_asset_blacklist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(senderAssetBlacklist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (recipientAssetWhitelist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("recipient_asset_whitelist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(recipientAssetWhitelist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (recipientAssetBlacklist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("recipient_asset_blacklist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(recipientAssetBlacklist, CultureInfo.InvariantCulture))).Append("&");
            }
            if (collectionWhitelist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("collection_whitelist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(collectionWhitelist, CultureInfo.InvariantCulture))).Append("&");
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

            return await _httpHandler.GetAsync<GetOffersResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);

        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Find offer by id</summary>
        /// <param name="offerId">ID of offer</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetOfferResponse> GetOffersAsync(int offerId, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (offerId == null)
                throw new ArgumentNullException("offerId");

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/offers/{offer_id}");
            urlBuilder.Replace("{offer_id}", Uri.EscapeDataString(Utils.ConvertToString(offerId, CultureInfo.InvariantCulture)));

            return await _httpHandler.GetAsync<GetOfferResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Fetch offer logs</summary>
        /// <param name="offerId">ID of offer</param>
        /// <param name="page">Result Page</param>
        /// <param name="limit">Results per Page</param>
        /// <param name="order">Order direction</param>
        /// <param name="actionWhitelist">Action whitelist</param>
        /// <param name="actionBlacklist">Action blacklist</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetLogsResponse> GetLogsAsync(int offerId, int? page = null, int? limit = null, Order? order = null, string actionWhitelist = null, int? actionBlacklist = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (offerId == null)
                throw new ArgumentNullException("offerId");

            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/offers/{offer_id}/logs?");
            urlBuilder.Replace("{offer_id}", Uri.EscapeDataString(Utils.ConvertToString(offerId, CultureInfo.InvariantCulture)));
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
