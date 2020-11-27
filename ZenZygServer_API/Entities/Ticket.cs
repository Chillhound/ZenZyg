using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Entities { 
    public class Ticket 
    {
       [Required]
        public string phoneNumber { get; set; }
        
        public int TicketId { get; set; }

        public int? StoreId { get; set; }

        public string QRData { get; set; }

        public int NumberInQueue { get; set; }

        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        
    }
}
