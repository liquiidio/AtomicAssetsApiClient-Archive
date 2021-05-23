using System.Collections.Generic;
using AtomicAssetsApi.Core.Assets;
using Newtonsoft.Json;

namespace AtomicAssetsApi.Core.Accounts
{
    public class GetAccountsResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccountData> Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class AccountData
    {
        [JsonProperty("collections", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Collection> Collections { get; set; }

        [JsonProperty("templates", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Template> Templates { get; set; }

        [JsonProperty("assets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Assets { get; set; }

    }

    public class GetAccountsByCollectionResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccountCollectionData> Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class AccountCollectionData
    {
        [JsonProperty("templates", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Template> Templates { get; set; }

        [JsonProperty("schemas", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Schema> Schemas { get; set; }

    }
}
