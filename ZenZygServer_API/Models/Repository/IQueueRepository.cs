using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using ZenZygServer_API.Models.DTO;

namespace ZenZygServer_API.Models
{
    public interface IQueueRepository
    {
        Task<int> Create(QueueCreateDTO Customer);
        Task<QueueDetailsDTO> Read(int Id);
        //Task<HttpStatusCode> Update(QueueUpdateDTO Queue);
        //  Task<HttpStatusCode> Delete(int CustomerId);

        Task<HttpStatusCode> EnterQueue(int ticketId);
        Task<HttpStatusCode> ExitQueue(int ticketId);
        Task<int> CountQueue(int ticketId);

    }
}
