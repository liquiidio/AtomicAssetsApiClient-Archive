using System.Collections.Generic;
using Newtonsoft.Json;

namespace AtomicAssetsApi.Core.Assets
{
    public class GetAssetsResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Asset> Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }
    }

    public class GetAssetStatsResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public AssetStats AssetStats { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class AssetStats
    {
        [JsonProperty("template_mint", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int TemplateMint { get; set; }

    }

    public class GetAssetResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Asset Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class Asset
    {
        [JsonProperty("contract", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Contract { get; set; }

        [JsonProperty("asset_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        [JsonProperty("owner", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        [JsonProperty("name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("is_transferable", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool IsTransferable { get; set; }

        [JsonProperty("is_burnable", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool IsBurnable { get; set; }

        [JsonProperty("collection", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Collection Collection { get; set; }

        [JsonProperty("schema", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Schema Schema { get; set; }

        [JsonProperty("template", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Template Template { get; set; }

        [JsonProperty("backed_tokens", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<BackedTokens> BackedTokens { get; set; }

        [JsonProperty("immutable_data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public object ImmutableData { get; set; }

        [JsonProperty("mutable_data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public object MutableData { get; set; }

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; set; }

        [JsonProperty("burned_by_account", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string BurnedByAccount { get; set; }

        [JsonProperty("burned_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string BurnedAtBlock { get; set; }

        [JsonProperty("burned_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string BurnedAtTime { get; set; }

        [JsonProperty("updated_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAtBlock { get; set; }

        [JsonProperty("updated_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAtTime { get; set; }

        [JsonProperty("transferred_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TransferredAtBlock { get; set; }

        [JsonProperty("transferred_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TransferredAtTime { get; set; }

        [JsonProperty("minted_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string MintedAtBlock { get; set; }

        [JsonProperty("minted_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string MintedAtTime { get; set; }
    }

    public class Collection
    {
        [JsonProperty("collection_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CollectionName { get; set; }

        [JsonProperty("name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("author", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        [JsonProperty("allow_notify", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool AllowNotify { get; set; }

        [JsonProperty("authorized_accounts", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> AuthorizedAccounts { get; set; }

        [JsonProperty("notify_accounts", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> NotifyAccounts { get; set; }

        [JsonProperty("market_fee", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double MarketFee { get; set; }

        [JsonProperty("created_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtTime { get; set; }

    }


    public class Schema
    {
        [JsonProperty("schema_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        [JsonProperty("format", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Format> Format { get; set; }

        [JsonProperty("created_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtTime { get; set; }

    }


    public class Template
    {
        [JsonProperty("template_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        [JsonProperty("max_supply", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string MaxSupply { get; set; }

        [JsonProperty("issued_supply", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string IssuedSupply { get; set; }

        [JsonProperty("is_transferable", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool IsTransferable { get; set; }

        [JsonProperty("is_burnable", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool IsBurnable { get; set; }

        [JsonProperty("immutable_data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public object ImmutableData { get; set; }

        [JsonProperty("created_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtTime { get; set; }

        [JsonProperty("created_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtBlock { get; set; }

    }


    public class BackedTokens
    {
        [JsonProperty("token_contract", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TokenContract { get; set; }

        [JsonProperty("token_symbol", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TokenSymbol { get; set; }

        [JsonProperty("token_precision", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int TokenPrecision { get; set; }

        [JsonProperty("amount", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

    }
}
