using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Entities { 
    public class Ticket 
    {
        public int TicketId { get; set; }

        public int? StoreId { get; set; }

        public Store Store { get; set; }
    
       // public QR QRCode { get; set; }

        public int NumberInQueue { get; set; }

        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        
    }
}
