using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtomicAssetsApi.Core.Templates
{
    public class GetTemplatesResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Template> Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }


    public class GetTemplateResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Template Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class GetTemplateStatsResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TemplateStats Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class TemplateStats
    {
        [JsonProperty("assets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Assets { get; set; }

        [JsonProperty("burned", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Burned { get; set; }

    }

    public class Template
    {
        [JsonProperty("contract", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Contract { get; set; }

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

        [JsonProperty("scheme", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Scheme Scheme { get; set; }

        [JsonProperty("collection", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Collection Collection { get; set; }

    }

    public class Scheme
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
}
