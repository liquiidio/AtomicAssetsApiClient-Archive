using AtomicAssetsApiClient.Schemas;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Schemas
{
    public class SchemasUriParameterBuilderTest
    {
        [Test]
        public void Build()
        {
            new SchemasUriParameterBuilder()
                .Build()
                .Should()
                .BeEquivalentTo("?");

            new SchemasUriParameterBuilder()
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
                .BeEquivalentTo("?&collection_name=collection&match=match&collection_blacklist=one,two&collection_whitelist=three,four&authorized_account=account&ids=id1,id2&lower_bound=1&upper_bound=5&before=10&after=1&page=2&limit=2&order=asc&sort=sort&schema_name=schemaName");
        }
    }
}
