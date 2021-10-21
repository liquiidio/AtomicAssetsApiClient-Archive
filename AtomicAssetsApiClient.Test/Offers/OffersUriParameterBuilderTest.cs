using AtomicAssetsApiClient.Offers;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Offers
{
    [TestFixture]
    public class OffersUriParameterBuilderTest
    {
        [Test]
        public void Build()
        {
            new OffersUriParameterBuilder()
                .Build()
                .Should()
                .BeEquivalentTo("?");

            new OffersUriParameterBuilder()
                .WithAccountWhitelist("white")
                .WithAccountBlacklist("black")
                .WithRecipient("recipient")
                .WithRecipientAssetWhitelist("reciAssWhitelist")
                .WithCollectionName("collection")
                .WithSchemaName("schemaName")
                .WithAfter(1)
                .WithBefore(10)
                .WithCollectionBlacklist(new []{"one", "two"})
                .WithCollectionWhitelist(new []{"three", "four"})
                .WithIds(new []{"id1", "id2"})
                .WithLowerBound("1")
                .WithUpperBound("5")
                .WithPage(2)
                .WithLimit(2)
                .WithSort("sort")
                .WithOrder(SortStrategy.Ascending)
                .Build()
                .Should()
                .BeEquivalentTo("?recipient=recipientaccount_whitelist=whiteaccount_blacklist=blackrecipient_asset_whitelist=reciAssWhitelist&collection_name=collection&collection_blacklist=one,two&collection_whitelist=three,four&ids=id1,id2&lower_bound=1&upper_bound=5&before=10&after=1&page=2&limit=2&order=asc&sort=sort&schema_name=schemaName");
        }
    }
}
