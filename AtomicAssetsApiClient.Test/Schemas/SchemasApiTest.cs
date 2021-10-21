using System.Linq;
using AtomicAssetsApiClient.Schemas;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Schemas
{
    [TestFixture]
    public class SchemasApiTest
    {
        [Test]
        public void Schemas()
        {
            AtomicAssetsApiFactory.Version1.SchemasApi.Schemas().Should().BeOfType<SchemasDto>();
            AtomicAssetsApiFactory.Version1.SchemasApi.Schemas().Data.Should().BeOfType<SchemasDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.SchemasApi.Schemas().Data.Should().HaveCountGreaterThan(1);
            AtomicAssetsApiFactory.Version1.SchemasApi.Schemas(new SchemasUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicAssetsApiFactory.Version1.SchemasApi.Schemas(new SchemasUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<SchemasDto>();
            AtomicAssetsApiFactory.Version1.SchemasApi.Schemas(new SchemasUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<SchemasDto.DataDto[]>();
        }

        [Test]
        public void Schema()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.SchemasApi.Schemas().Data.First().Collection.CollectionName;
            var schemaNameToFind = AtomicAssetsApiFactory.Version1.SchemasApi.Schemas().Data.First().SchemaName;
            AtomicAssetsApiFactory.Version1.SchemasApi.Schema(collectionNameToFind, schemaNameToFind).Should().BeOfType<SchemaDto>();
            AtomicAssetsApiFactory.Version1.SchemasApi.Schema(collectionNameToFind, schemaNameToFind).Data.Should().BeOfType<SchemaDto.DataDto>();
        }

        [Test]
        public void SchemaStats()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.SchemasApi.Schemas().Data.First().Collection.CollectionName;
            var schemaNameToFind = AtomicAssetsApiFactory.Version1.SchemasApi.Schemas().Data.First().SchemaName;
            AtomicAssetsApiFactory.Version1.SchemasApi.SchemaStats(collectionNameToFind, schemaNameToFind).Should().BeOfType<StatsDto>();
            AtomicAssetsApiFactory.Version1.SchemasApi.SchemaStats(collectionNameToFind, schemaNameToFind).Data.Should().BeOfType<StatsDto.DataDto>();
        }

        [Test]
        public void SchemaLogs()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.SchemasApi.Schemas().Data.First().Collection.CollectionName;
            var schemaNameToFind = AtomicAssetsApiFactory.Version1.SchemasApi.Schemas().Data.First().SchemaName;
            AtomicAssetsApiFactory.Version1.SchemasApi.SchemaLogs(collectionNameToFind, schemaNameToFind).Should().BeOfType<LogsDto>();
            AtomicAssetsApiFactory.Version1.SchemasApi.SchemaLogs(collectionNameToFind, schemaNameToFind).Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}