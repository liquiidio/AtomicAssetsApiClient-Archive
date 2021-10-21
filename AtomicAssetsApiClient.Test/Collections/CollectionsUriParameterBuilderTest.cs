using AtomicAssetsApiClient.Collections;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Collections
{
    public class CollectionsUriParameterBuilderTest
    {
        [Test]
        public void Build()
        {
            new CollectionsUriParameterBuilder()
                .Build()
                .Should()
                .BeEquivalentTo("?");

            new CollectionsUriParameterBuilder()
                .WithAuthor("me")
                .WithNotifyAccount("notifythisone")
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
                .BeEquivalentTo("?&author=me&match=match&authorized_account=account&notify_account=notifythisone&collection_blacklist=one,two&collection_whitelist=three,four&ids=id1,id2&lower_bound=1&upper_bound=5&before=10&after=1&page=2&limit=2&order=asc&sort=sort");
        }
    }
}
