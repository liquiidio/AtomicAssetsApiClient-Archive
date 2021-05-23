using System.Threading;
using System.Threading.Tasks;
using AtomicAssetsApi.Core.Assets;
using NUnit.Framework;

namespace AtomicAssetsApi.CoreTests.Assets
{
    [TestFixture()]
    public class AssetsClientTests
    {
        [Test()]
        public async Task GetAssetsAsyncTest()
        {
            var httpHandler = new HttpHandler();
            var assetsClient = new AssetsClient(httpHandler);
            var getAssetsResponse = await assetsClient.GetAssetsAsync();

            Assert.Fail();
        }

        [Test()]
        public async Task GetAssetsAsyncTest1()
        {
            string assetId = "";

            var httpHandler = new HttpHandler();
            var assetsClient = new AssetsClient(httpHandler);
            var getAssetsResponse = await assetsClient.GetAssetsAsync(assetId, CancellationToken.None);

            Assert.Fail();
        }

        [Test()]
        public async Task GetStatsAsyncTest()
        {
            int assetId = 0;

            var httpHandler = new HttpHandler();
            var assetsClient = new AssetsClient(httpHandler);
            var getStatsResponse = await assetsClient.GetStatsAsync(assetId, CancellationToken.None);

            Assert.Fail();
        }

        [Test()]
        public async Task GetLogsAsyncTest()
        {
            int assetId = 0;

            var httpHandler = new HttpHandler();
            var assetsClient = new AssetsClient(httpHandler);
            var getStatsResponse = await assetsClient.GetLogsAsync(assetId);

            Assert.Fail();
        }
    }
}