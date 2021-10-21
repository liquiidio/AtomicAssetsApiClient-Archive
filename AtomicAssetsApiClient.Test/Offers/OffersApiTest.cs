using System.Linq;
using AtomicAssetsApiClient.Offers;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Offers
{
    [TestFixture]
    public class OffersApiTest
    {
        [Test]
        public void Offers()
        {
            AtomicAssetsApiFactory.Version1.OffersApi.Offers().Should().BeOfType<OffersDto>();
            AtomicAssetsApiFactory.Version1.OffersApi.Offers().Data.Should().BeOfType<OffersDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.OffersApi.Offers().Data.Should().HaveCountGreaterThan(1);
            AtomicAssetsApiFactory.Version1.OffersApi.Offers(new OffersUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicAssetsApiFactory.Version1.OffersApi.Offers(new OffersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<OffersDto>();
            AtomicAssetsApiFactory.Version1.OffersApi.Offers(new OffersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<OffersDto.DataDto[]>();
        }

        [Test]
        public void Offer()
        {
            var offerIdToFind = AtomicAssetsApiFactory.Version1.OffersApi.Offers().Data.First().OfferId;
            AtomicAssetsApiFactory.Version1.OffersApi.Offer(offerIdToFind).Should().BeOfType<OfferDto>();
            AtomicAssetsApiFactory.Version1.OffersApi.Offer(offerIdToFind).Data.Should().BeOfType<OfferDto.DataDto>();
        }

        [Test]
        [Ignore("This test is failing at the moment as the AtomicAssents endpoint is down. We always receive an Internal Server Error. Add this test back in when their endpoint is working again")]

        public void OfferLogs()
        {
            var offerIdToFind = AtomicAssetsApiFactory.Version1.OffersApi.Offers().Data.First().OfferId;
            AtomicAssetsApiFactory.Version1.OffersApi.OfferLogs(offerIdToFind).Should().BeOfType<LogsDto>();
            AtomicAssetsApiFactory.Version1.OffersApi.OfferLogs(offerIdToFind).Data.Should().BeOfType<LogsDto.DataDto[]>();
        }
    }
}