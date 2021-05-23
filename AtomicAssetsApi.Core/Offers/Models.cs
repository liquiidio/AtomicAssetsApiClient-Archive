using System.Collections.Generic;
using Newtonsoft.Json;

namespace AtomicAssetsApi.Core.Offers
{
    public class GetOffersResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Offer> Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }


    public class GetOfferResponse
    {
        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; } = true;

        [JsonProperty("data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Offer Data { get; set; }

        [JsonProperty("query_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTime { get; set; }

    }

    public class Offer
    {
        [JsonProperty("contract", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Contract { get; set; }

        [JsonProperty("offer_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string OfferId { get; set; }

        [JsonProperty("sender_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string SenderName { get; set; }

        [JsonProperty("recipient_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string RecipientName { get; set; }

        [JsonProperty("memo", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        [JsonProperty("state", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int State { get; set; }

        [JsonProperty("is_sender_contract", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool IsSenderContract { get; set; }

        [JsonProperty("is_recipient_contract", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool IsRecipientContract { get; set; }

        [JsonProperty("sender_assets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Assets.Asset> SenderAssets { get; set; }

        [JsonProperty("recipient_assets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Assets.Asset> RecipientAssets { get; set; }

        [JsonProperty("updated_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAtBlock { get; set; }

        [JsonProperty("updated_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAtTime { get; set; }

        [JsonProperty("created_at_block", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtBlock { get; set; }

        [JsonProperty("created_at_time", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAtTime { get; set; }
    }

}
