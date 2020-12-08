using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace ZenZygServer_API.Models
{
    public interface IStoreRepository
    {
        Task<int> Create (StoreCreateDTO Store);
        Task<StoreDetailsDTO> Read (int StoreId);
        IQueryable<StoreListDTO> ReadAll();
        Task<HttpStatusCode> Update (StoreUpdateDTO Store);
        Task<HttpStatusCode> Delete (int StoreId);
    }
}