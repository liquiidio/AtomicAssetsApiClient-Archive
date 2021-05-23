using System.Threading;
using System.Threading.Tasks;

namespace AtomicAssetsApi.Core
{
    public interface IHttpHandler
    {
        Task<TResponseData> GetAsync<TResponseData>(string url, CancellationToken cancellationToken);
    }
}