using System.Linq;
using System.Threading.Tasks;

namespace ZenZygServer_API.Models
{
    public class IStoreManagerRepository
    {
        Task<(Status response, int StoreManagerId)> Create (StoreManagerCreateDTO Customer);
        Task<StoreManagerDetailsDTO> Read (int StoreManagerId);
        Task<Status> Update (StoreManagerUpdateDTO StoreManager);
        Task<Status> Delete (int StoreManagerId);
    }
}