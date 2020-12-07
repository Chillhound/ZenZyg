using System;
using System.Collections;
using System.Threading.Tasks;

namespace ZenZygServer_API.Models.DTO
{
    public class QueueDetailsDTO
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public ArrayList TicketQueue { get; set; }
    }
}
