
# AtomicAssetsApiClient

.NET and Unity3D-compatible (Desktop, Mobile, WebGL) ApiClient for AtomicAssets

## Examples

### Accounts
	    var accountsClient = new AccountsClient(new HttpHandler());
	    ICollection<AccountData> accounts = (await accountsClient.GetAccountsAsync("account", false)).Data; 

### Assets
		var assetsClient = new AssetsClient(new HttpHandler());
		ICollection<Asset> assets = (await assetsClient.GetAssetsAsync("account", false)).Data;

### Burns
        var burnsClient = new BurnsClient(new HttpHandler());
        ICollection<BurnsData> burns = (await burnsClient.GetBurnsAsync("account",false)).Data;

### Collections
         var collectionsClient = new CollectionsClient(new HttpHandler());
         ICollection<Collection> collections = (await collectionsClient.GetCollectionsAsync("autor","match")).Data;

### Offers
         var offersClient = new OffersClient(new HttpHandler());
         ICollection<Offer> offers = (await offersClient.GetOffersAsync("account")).Data;

### Schemas
         var schemasClient = new SchemasClient(new HttpHandler());
         ICollection<Schema> schemas = (await schemasClient.GetSchemasAsync("collname")).Data;

### Templates
         var templatesClient = new TemplatesClient(new HttpHandler());
         ICollection<Template> templates = (await templatesClient.GetTemplatesAsync("collname")).Data;

### Transfers
         var transfersClient = new TransfersClient(new HttpHandler());
         ICollection<Transfer> transfers = (await transfersClient.GetTransfersAsync("account")).Data;

