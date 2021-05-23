using System;
using System.Collections.Generic;
using System.Text;
using AtomicAssetsApi.Core.Assets;
using Newtonsoft.Json;

namespace AtomicAssetsApi.Core.Transfers
{
    public class GetTransferResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Transfer> Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class Transfer
    {
        [JsonProperty("contract", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Contract { get; set; }

        [JsonProperty("transfer_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TransferId { get; set; }

        [JsonProperty("sender_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string SenderName { get; set; }

        [JsonProperty("recipient_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string RecipientName { get; set; }

        [JsonProperty("memo", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        [JsonProperty("assets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Asset> Assets { get; set; }

        [JsonProperty("created_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtTime { get; set; }
    }
}
