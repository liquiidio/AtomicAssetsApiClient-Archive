using AtomicAssetsApiClient.Config;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicAssetsApiClient.Test.Config
{
    [TestFixture]
    public class ConfigApiTest
    {
        [Test]
        public void Config()
        {
            AtomicAssetsApiFactory.Version1.ConfigApi.Config().Should().BeOfType<ConfigDto>();
        }
    }
}
