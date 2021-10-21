using AtomicAssetsApiClient.Accounts;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Accounts
{
    [TestFixture]
    public class AccountsUriParameterBuilderTest
    {
        [Test]
        public void Build()
        {
            new AccountsUriParameterBuilder()
                .Build()
                .Should()
                .BeEquivalentTo("?");

            new AccountsUriParameterBuilder()
                .WithCollectionName("collectionName")
                .WithSchemaName("schemaName")
                .WithTemplateId("1")
                .WithMatch("match")
                .WithCollectionBlacklist(new []{"one", "two"})
                .WithCollectionWhitelist(new []{"three", "four"})
                .WithHideOffers(false)
                .WithIds(new []{"id1", "id2"})
                .WithLowerBound("1")
                .WithUpperBound("5")
                .WithPage(2)
                .WithLimit(2)
                .WithOrder(SortStrategy.Ascending)
                .Build()
                .Should()
                .BeEquivalentTo("?&match=match&hide_offers=False&collection_name=collectionName&schema_name=schemaName&template_id=1&collection_blacklist=one,two&collection_whitelist=three,four&ids=id1,id2&lower_bound=1&upper_bound=5&page=2&limit=2&order=asc");
        }
    }
}
