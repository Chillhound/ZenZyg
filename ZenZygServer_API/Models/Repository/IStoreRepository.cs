using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace ZenZygServer_API.Models
{
    public interface IStoreRepository
    {
        Task<HttpStatusCode> Create (StoreCreateDTO Store);
        Task<StoreDetailsDTO> Read (int StoreId);
        Task<HttpStatusCode> Update (StoreUpdateDTO Store);
        Task<HttpStatusCode> Delete (int StoreId);
    }
}