using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace ZenZygServer_API.Models
{
    public interface IStoreManagerRepository
    {
        Task<HttpStatusCode> Create (StoreManagerCreateDTO StoreManager);
        Task<StoreManagerDetailsDTO> Read (int StoreManagerId);
        Task<HttpStatusCode> Update (StoreManagerUpdateDTO StoreManager);
        Task<HttpStatusCode> Delete (int StoreManagerId);
        
    }
}