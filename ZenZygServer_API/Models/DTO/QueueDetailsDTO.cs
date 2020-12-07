using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ZenZygServer_API.Models.DTO
{
    public class QueueDetailsDTO
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public Queue<int> TicketQueue { get; set; }
    }
}
