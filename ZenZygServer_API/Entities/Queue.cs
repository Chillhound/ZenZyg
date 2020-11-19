using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace ZenZygServer_API.Entities
{
    public class Queue
    {
        public int QueueId { get; set; }

        public DateTime Date { get; set; }

        public ICollection<Ticket> TicketQueue { get; set; }

    }
    
}