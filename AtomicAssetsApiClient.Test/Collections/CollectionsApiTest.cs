using System.Linq;
using AtomicAssetsApiClient.Collections;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Collections
{
    [TestFixture]
    public class CollectionsApiTest
    {
        [Test]
        public void Collections()
        {
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Should().BeOfType<CollectionsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.Should().BeOfType<CollectionsDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.Should().HaveCountGreaterThan(1);
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections(new CollectionsUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections(new CollectionsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<CollectionsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections(new CollectionsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<CollectionsDto.DataDto[]>();
        }

        [Test]
        public void Collection()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.First().CollectionName;
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collection(collectionNameToFind).Should().BeOfType<CollectionDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collection(collectionNameToFind).Data.Should().BeOfType<CollectionDto.DataDto>();
        }

        [Test]
        public void CollectionStats()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.First().CollectionName;
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionStats(collectionNameToFind).Should().BeOfType<StatsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionStats(collectionNameToFind).Data.Should().BeOfType<StatsDto.DataDto>();
        }

        [Test]
        public void CollectionLogs()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.First().CollectionName;
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionLogs(collectionNameToFind).Should().BeOfType<LogsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionLogs(collectionNameToFind).Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}