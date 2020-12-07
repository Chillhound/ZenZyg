using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenZygServer_API.Models 
{
   public interface ITicketRepository
    {
        Task<int> Create(TicketCreateDTO ticket);

        Task<TicketDetailsDTO> Read(int ticketId);

        Task<HttpStatusCode> Delete(int ticketId);
    }
}
