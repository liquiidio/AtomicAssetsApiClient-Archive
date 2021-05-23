using System.Threading;
using System.Threading.Tasks;
using AtomicAssetsApi.Core.Accounts;
using NUnit.Framework;

namespace AtomicAssetsApi.CoreTests.Accounts
{
    [TestFixture()]
    public class AccountsClientTests
    {
        [Test()]
        public async Task AccountsGetAsyncTest()
        {
            string accountName = "";

            var httpHandler = new HttpHandler();
            var accountsClient = new AccountsClient(httpHandler);
            var getAccountsResponse = await accountsClient.GetAccountsAsync(accountName, false);

            Assert.True(getAccountsResponse.Success);
            Assert.NotNull(getAccountsResponse.Data);
            Assert.NotNull(getAccountsResponse);
        }

        [Test()]
        public async Task AccountsGetAsyncTest1()
        {
            string accountName = "";
            string collectionName = "";

            var httpHandler = new HttpHandler();
            var accountsClient = new AccountsClient(httpHandler);
            var getAccountsResponse = await accountsClient.GetAccountsAsync(accountName, collectionName, CancellationToken.None);

            Assert.True(getAccountsResponse.Success);
            Assert.NotNull(getAccountsResponse.Data);
            Assert.NotNull(getAccountsResponse);
        }

        [Test()]
        public async Task AccountsGetAsyncTest2()
        {
            string accountName = "";
            string collectionName = "";
            string schemaName = "";

            var httpHandler = new HttpHandler();
            var accountsClient = new AccountsClient(httpHandler);
            var getAccountsResponse = await accountsClient.GetAccountsAsync(accountName, collectionName, schemaName);

            Assert.True(getAccountsResponse.Success);
            Assert.NotNull(getAccountsResponse.Data);
            Assert.NotNull(getAccountsResponse);
        }
    }
}