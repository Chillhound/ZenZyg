using System.Linq;
using System.Threading.Tasks;

namespace ZenZygServer_API.Models
{
    public class IStoreRepository
    {
        Task<(Status response, int StoreId)> Create (StoreCreateDTO Store);
        Task<StoreDetailsDTO> Read (int StoreId);
        Task<Status> Update (StoreUpdateDTO Store);
        Task<Status> Delete (int StoreId);
    }
}