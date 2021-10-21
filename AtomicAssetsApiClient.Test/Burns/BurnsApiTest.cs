using System.Linq;
using AtomicAssetsApiClient.Burns;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Burns
{
    [TestFixture]
    public class BurnsApiTest
    {
        [Test]
        public void Burns()
        {
            AtomicAssetsApiFactory.Version1.BurnsApi.Burns().Should().BeOfType<BurnsDto>();
            AtomicAssetsApiFactory.Version1.BurnsApi.Burns().Data.Should().BeOfType<BurnsDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.BurnsApi.Burns().Data.Should().HaveCountGreaterThan(1);
            AtomicAssetsApiFactory.Version1.BurnsApi.Burns(new BurnsUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicAssetsApiFactory.Version1.BurnsApi.Burns(new BurnsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<BurnsDto>();
            AtomicAssetsApiFactory.Version1.BurnsApi.Burns(new BurnsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<BurnsDto.DataDto[]>();
        }

        [Test]
        public void Account()
        {
            var accountNameToFind = AtomicAssetsApiFactory.Version1.BurnsApi.Burns().Data.First().Account;
            AtomicAssetsApiFactory.Version1.BurnsApi.Account(accountNameToFind).Should().BeOfType<BurnDto>();
            AtomicAssetsApiFactory.Version1.BurnsApi.Account(accountNameToFind).Data.Should().BeOfType<BurnDto.DataDto>();
        }
    }
}