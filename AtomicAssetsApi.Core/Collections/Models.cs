using System.Collections.Generic;
using Newtonsoft.Json;

namespace AtomicAssetsApi.Core.Collections
{
    public class GetCollectionsResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Collection> Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class GetCollectionResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Collection Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class GetCollectionStatsResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CollectionStats Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class Collection
    {
        [JsonProperty("contract", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Contract { get; set; }

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

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; set; }

        [JsonProperty("created_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtTime { get; set; }

    }

    public class CollectionStats
    {
        [JsonProperty("assets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Assets { get; set; }

        [JsonProperty("burned", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Burned { get; set; }

        [JsonProperty("templates", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Templates { get; set; }

        [JsonProperty("schemas", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Schemas { get; set; }

    }
}
