using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenZygClient.Models
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        
        public int? StoreId { get; set; }
        
        public string QRData { get; set; }
        
        public int? CustomerId { get; set; }
    }
}
