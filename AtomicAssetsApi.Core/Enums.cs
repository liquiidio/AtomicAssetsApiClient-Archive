using System.Runtime.Serialization;

namespace AtomicAssetsApi.Core
{

    public enum Order
    {
        [EnumMember(Value = @"asc")]
        Asc = 0,

        [EnumMember(Value = @"desc")]
        Desc = 1,

    }


    public enum Sort
    {
        [EnumMember(Value = @"asset_id")]
        AssetId = 0,

        [EnumMember(Value = @"minted")]
        Minted = 1,

        [EnumMember(Value = @"updated")]
        Updated = 2,

        [EnumMember(Value = @"transferred")]
        Transferred = 3,

        [EnumMember(Value = @"template_mint")]
        TemplateMint = 4,

    }

    public enum Sort2
    {
        [EnumMember(Value = @"created")]
        Created = 0,

        [EnumMember(Value = @"collection_name")]
        CollectionName = 1,

    }



    public enum Sort3
    {
        [EnumMember(Value = @"created")]
        Created = 0,

        [EnumMember(Value = @"schema_name")]
        SchemaName = 1,

    }


    public enum Sort4
    {
        [EnumMember(Value = @"created")]
        Created = 0,

    }


    public enum Sort5
    {
        [EnumMember(Value = @"created")]
        Created = 0,

        [EnumMember(Value = @"updated")]
        Updated = 1,

    }

}
