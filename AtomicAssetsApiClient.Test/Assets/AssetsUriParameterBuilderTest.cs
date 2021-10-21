using AtomicAssetsApiClient.Assets;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Assets
{
    public class AssetsUriParameterBuilderTest
    {
        [Test]
        public void Build()
        {
            new AssetsUriParameterBuilder()
                .Build()
                .Should()
                .BeEquivalentTo("?");

            new AssetsUriParameterBuilder()
                .WithAfter(1)
                .WithBefore(10)
                .WithCollectionName("collectionName")
                .WithSchemaName("schemaName")
                .WithTemplateId(1)
                .WithMatch("match")
                .WithOnlyDuplicateTemplate(true)
                .WithOwner("me")
                .WithCollectionBlacklist(new []{"one", "two"})
                .WithCollectionWhitelist(new []{"three", "four"})
                .WithAuthorisedAccount("account")
                .WithHideOffers(false)
                .WithIds(new []{"id1", "id2"})
                .WithLowerBound("1")
                .WithUpperBound("5")
                .WithPage(2)
                .WithLimit(2)
                .WithSort("sort")
                .WithOrder(SortStrategy.Ascending)
                .Build()
                .Should()
                .BeEquivalentTo("?&owner=me&collection_name=collectionName&template_id=1&match=match&collection_blacklist=one,two&collection_whitelist=three,four&only_duplicate_templates=True&authorized_account=account&hide_offers=False&ids=id1,id2&lower_bound=1&upper_bound=5&before=10&after=1&page=2&limit=2&order=asc&sort=sort&schema_name=schemaName");
        }
    }
}
