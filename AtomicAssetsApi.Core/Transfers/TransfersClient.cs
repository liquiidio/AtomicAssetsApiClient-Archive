using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtomicAssetsApi.Core.Transfers
{
    public class TransfersClient
    {
        private string _baseUrl = "https://wax.api.atomicassets.io/atomicassets";
        private IHttpHandler _httpHandler;


        public TransfersClient(IHttpHandler httpHandler, string baseUrl = null)
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
        /// <summary>Fetch transfers</summary>
        /// <param name="account">Notified account (can be sender or recipient) - separate multiple with ","</param>
        /// <param name="sender">Transfer sender - separate multiple with ","</param>
        /// <param name="recipient">Transfer recipient - separate multiple with ","</param>
        /// <param name="assetId">only transfers which contain this asset_id - separate multiple with ","</param>
        /// <param name="templateId">only transfers which contain assets of this template - separate multiple with ","</param>
        /// <param name="schemaName">only transfers which contain assets of this schema - separate multiple with ","</param>
        /// <param name="collectionName">only transfers which contain assets of this collection - separate multiple with ","</param>
        /// <param name="collectionBlacklist">Hide collections from result. Split multiple with ","</param>
        /// <param name="collectionWhitelist">Show only results from specific collections. Split multiple with ","</param>
        /// <param name="page">Result Page</param>
        /// <param name="limit">Results per Page</param>
        /// <param name="order">Order direction</param>
        /// <param name="sort">Column to sort</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetTransferResponse> GetTransfersAsync(string account = null, string sender = null, string recipient = null, string assetId = null, string templateId = null, string schemaName = null, string collectionName = null, string collectionBlacklist = null, string collectionWhitelist = null, int? page = null, int? limit = null, Order? order = null, Sort4? sort = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/transfers?");
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
            if (collectionBlacklist != null)
            {
                urlBuilder.Append(Uri.EscapeDataString("collection_blacklist") + "=").Append(Uri.EscapeDataString(Utils.ConvertToString(collectionBlacklist, CultureInfo.InvariantCulture))).Append("&");
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

            return await _httpHandler.GetAsync<GetTransferResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);
        }

    }

}
