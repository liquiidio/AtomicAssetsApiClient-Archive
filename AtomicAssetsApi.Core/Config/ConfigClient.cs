using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtomicAssetsApi.Core.Config
{
    public class ConfigClient
    {
        private string _baseUrl = "https://wax.api.atomicassets.io/atomicassets";
        private IHttpHandler _httpHandler;

        public ConfigClient(IHttpHandler httpHandler, string baseUrl = null)
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
        /// <summary>Get general information about the API and the connected contract</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<GetConfigResponse> GetConfigAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/config");

            return await _httpHandler.GetAsync<GetConfigResponse>(urlBuilder.ToString(), cancellationToken).ConfigureAwait(false);
        }

    }
}
