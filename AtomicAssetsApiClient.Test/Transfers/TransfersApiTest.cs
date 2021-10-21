using AtomicAssetsApiClient.Transfers;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Transfers
{
    [TestFixture]
    public class TransfersApiTest
    {
        [Test]
        public void Transfers()
        {
            AtomicAssetsApiFactory.Version1.TransfersApi.Transfers().Should().BeOfType<TransfersDto>();
            AtomicAssetsApiFactory.Version1.TransfersApi.Transfers().Data.Should().BeOfType<TransfersDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.TransfersApi.Transfers().Data.Should().HaveCountGreaterThan(1);
            AtomicAssetsApiFactory.Version1.TransfersApi.Transfers(new TransfersUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicAssetsApiFactory.Version1.TransfersApi.Transfers(new TransfersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<TransfersDto>();
            AtomicAssetsApiFactory.Version1.TransfersApi.Transfers(new TransfersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<TransfersDto.DataDto[]>();
        }
    }
}
