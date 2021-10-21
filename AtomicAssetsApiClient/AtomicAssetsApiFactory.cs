using AtomicAssetsApiClient.Accounts;
using AtomicAssetsApiClient.Assets;
using AtomicAssetsApiClient.Burns;
using AtomicAssetsApiClient.Collections;
using AtomicAssetsApiClient.Config;
using AtomicAssetsApiClient.Offers;
using AtomicAssetsApiClient.Schemas;
using AtomicAssetsApiClient.Templates;
using AtomicAssetsApiClient.Transfers;

namespace AtomicAssetsApiClient
{
    public class AtomicAssetsApiFactory
    {
        private readonly string _baseUrl;
        private const string Version1BaseUrl = "http://api.wax.liquidstudios.io/atomicassets/v1";

        private AtomicAssetsApiFactory(string baseUrl) => _baseUrl = baseUrl;

        public static AtomicAssetsApiFactory Version1 => new AtomicAssetsApiFactory(Version1BaseUrl);

        public AccountsApi AccountsApi => new AccountsApi(_baseUrl);

        public AssetsApi AssetsApi => new AssetsApi(_baseUrl);
        
        public BurnsApi BurnsApi => new BurnsApi(_baseUrl);

        public CollectionsApi CollectionsApi => new CollectionsApi(_baseUrl);
        
        public ConfigApi ConfigApi => new ConfigApi(_baseUrl);
        
        public OffersApi OffersApi => new OffersApi(_baseUrl);

        public SchemasApi SchemasApi => new SchemasApi(_baseUrl);
        
        public TemplatesApi TemplatesApi => new TemplatesApi(_baseUrl);
        
        public TransfersApi TransfersApi => new TransfersApi(_baseUrl);
    }
}
