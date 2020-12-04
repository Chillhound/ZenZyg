using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace ZenZygServer_API.Models
{
    public interface ICustomerRepository
    {
        Task<int> Create (CustomerCreateDTO Customer);
        Task<CustomerDetailsDTO> Read (int CustomerId);
        Task<HttpStatusCode> Update (CustomerUpdateDTO Customer);
        Task<HttpStatusCode> Delete (int CustomerId);
    }    
}