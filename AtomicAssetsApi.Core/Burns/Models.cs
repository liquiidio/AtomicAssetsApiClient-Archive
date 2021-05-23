using System.Collections.Generic;
using Newtonsoft.Json;

namespace AtomicAssetsApi.Core.Burns
{
    public class GetBurnsResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccountData> Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class GetBurnsByAccountResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<BurnsData> Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class BurnsData
    {
        [JsonProperty("collections", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CollectionData> Collections { get; set; }

        [JsonProperty("templates", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TemplateData> Templates { get; set; }

        [JsonProperty("assets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Assets { get; set; }

    }

    public class CollectionData
    {
        [JsonProperty("collection_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CollectionName { get; set; }

        [JsonProperty("assets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Assets { get; set; }

    }


    public class TemplateData
    {
        [JsonProperty("collection_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CollectionName { get; set; }

        [JsonProperty("template_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        [JsonProperty("assets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Assets { get; set; }

    }

    public class AccountData
    {
        [JsonProperty("account", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        [JsonProperty("assets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Assets { get; set; }

    }
}
