using AtomicAssetsApiClient.Transfers;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Transfers
{
    [TestFixture]
    public class TransfersUriParameterBuilderTest
    {
        [Test]
        public void Build()
        {
            new TransfersUriParameterBuilder()
                .Build()
                .Should()
                .BeEquivalentTo("?");

            new TransfersUriParameterBuilder()
                .WithAccount("account")
                .WithRecipient("recipienet")
                .WithAssetId("1")
                .WithSender("sender")
                .WithCollectionName("collection")
                .WithSchemaName("schemaName")
                .WithCollectionBlacklist(new []{"one", "two"})
                .WithCollectionWhitelist(new []{"three", "four"})
                .WithPage(2)
                .WithLimit(2)
                .WithSort("sort")
                .WithOrder(SortStrategy.Ascending)
                .Build()
                .Should()
                .BeEquivalentTo("?&account=account&sender=sender&recipient=recipienet&asset_id=1&collection_name=collection&collection_blacklist=one,two&collection_whitelist=three,four&page=2&limit=2&order=asc&sort=sort&schema_name=schemaName");
        }
    }
}
