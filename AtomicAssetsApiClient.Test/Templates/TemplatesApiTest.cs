using System.Linq;
using AtomicAssetsApiClient.Templates;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Templates
{
    [TestFixture]
    public class TemplatesApiTest
    {
        [Test]
        public void Templates()
        {
            AtomicAssetsApiFactory.Version1.TemplatesApi.Templates().Should().BeOfType<TemplatesDto>();
            AtomicAssetsApiFactory.Version1.TemplatesApi.Templates().Data.Should().BeOfType<TemplatesDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.TemplatesApi.Templates().Data.Should().HaveCountGreaterThan(1);
            AtomicAssetsApiFactory.Version1.TemplatesApi.Templates(new TemplatesUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicAssetsApiFactory.Version1.TemplatesApi.Templates(new TemplatesUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<TemplatesDto>();
            AtomicAssetsApiFactory.Version1.TemplatesApi.Templates(new TemplatesUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<TemplatesDto.DataDto[]>();
        }

        [Test]
        public void Template()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.TemplatesApi.Templates().Data.First().Collection.CollectionName;
            var templateIdToFind = AtomicAssetsApiFactory.Version1.TemplatesApi.Templates().Data.First().TemplateId;
            AtomicAssetsApiFactory.Version1.TemplatesApi.Template(collectionNameToFind, templateIdToFind).Should().BeOfType<TemplateDto>();
            AtomicAssetsApiFactory.Version1.TemplatesApi.Template(collectionNameToFind, templateIdToFind).Data.Should().BeOfType<TemplateDto.DataDto>();
        }

        [Test]
        public void TemplateStats()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.TemplatesApi.Templates().Data.First().Collection.CollectionName;
            var templateIdToFind = AtomicAssetsApiFactory.Version1.TemplatesApi.Templates().Data.First().TemplateId;
            AtomicAssetsApiFactory.Version1.TemplatesApi.TemplateStats(collectionNameToFind, templateIdToFind).Should().BeOfType<StatsDto>();
            AtomicAssetsApiFactory.Version1.TemplatesApi.TemplateStats(collectionNameToFind, templateIdToFind).Data.Should().BeOfType<StatsDto.DataDto>();
        }

        [Test]
        public void TemplateLogs()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.TemplatesApi.Templates().Data.First().Collection.CollectionName;
            var templateIdToFind = AtomicAssetsApiFactory.Version1.TemplatesApi.Templates().Data.First().TemplateId;
            AtomicAssetsApiFactory.Version1.TemplatesApi.TemplateLogs(collectionNameToFind, templateIdToFind).Should().BeOfType<LogsDto>();
            AtomicAssetsApiFactory.Version1.TemplatesApi.TemplateLogs(collectionNameToFind, templateIdToFind).Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}