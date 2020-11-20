using System.Linq;
using System.Threading.Tasks;

namespace ZenZygServer_API.Models
{
    public interface ICustomerRepository
    {
        Task<(Status response, int CustomerId)> Create (CustomerCreateDTO Customer);
        Task<CustomerDetailsDTO> Read (int CustomerId);
        Task<Status> Update (CustomerUpdateDTO Customer);
        Task<Status> Delete (int CustomerId);
    }    
}