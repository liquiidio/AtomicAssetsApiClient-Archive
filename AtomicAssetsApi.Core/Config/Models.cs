using System.Collections.Generic;
using Newtonsoft.Json;

namespace AtomicAssetsApi.Core.Config
{
    public class GetConfigResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ConfigData Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class ConfigData
    {
        [JsonProperty("contract", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Contract { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("collection_format", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CollectionFormat> CollectionFormat { get; set; }

        [JsonProperty("supported_tokens", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SupportedTokens> SupportedTokens { get; set; }

    }

    public class CollectionFormat
    {
        [JsonProperty("name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

    }

    public class SupportedTokens
    {
        [JsonProperty("token_contract", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TokenContract { get; set; }

        [JsonProperty("token_symbol", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TokenSymbol { get; set; }

        [JsonProperty("token_precision", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int TokenPrecision { get; set; }

    }
}
