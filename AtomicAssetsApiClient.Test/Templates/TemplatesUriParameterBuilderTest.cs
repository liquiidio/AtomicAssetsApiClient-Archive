using AtomicAssetsApiClient.Templates;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Templates
{
    [TestFixture]
    public class TemplatesUriParameterBuilderTest
    {
        [Test]
        public void Build()
        {
            new TemplatesUriParameterBuilder()
                .Build()
                .Should()
                .BeEquivalentTo("?");

            new TemplatesUriParameterBuilder()
                .WithIssuedSupply(1)
                .WithMinIssuedSupply(1)
                .WithMaxIssuedSupply(5)
                .WithMaxSupply(5)
                .WithHasAssets(false)
                .WithIsBurnable(false)
                .WithIsTransferable(true)
                .WithCollectionName("collection")
                .WithSchemaName("schemaName")
                .WithAfter(1)
                .WithBefore(10)
                .WithMatch("match")
                .WithCollectionBlacklist(new []{"one", "two"})
                .WithCollectionWhitelist(new []{"three", "four"})
                .WithAuthorisedAccount("account")
                .WithIds(new []{"id1", "id2"})
                .WithLowerBound("1")
                .WithUpperBound("5")
                .WithPage(2)
                .WithLimit(2)
                .WithSort("sort")
                .WithOrder(SortStrategy.Ascending)
                .Build()
                .Should()
                .BeEquivalentTo("?&collection_name=collection&match=match&collection_blacklist=one,two&collection_whitelist=three,four&authorized_account=account&ids=id1,id2&lower_bound=1&upper_bound=5&before=10&after=1&page=2&limit=2&order=asc&sort=sort&schema_name=schemaName&issued_supply=1&min_issued_supply=1&max_issued_supply=5&has_assets=False&max_supply=5&is_burnable=False&is_transferable=True");
        }
    }
}
