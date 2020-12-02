using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Entities { 
    public class Ticket 
    {
     
        public int TicketId { get; set; }
        [Required]
        public int? StoreId { get; set; }
        [Required]
        public string QRData { get; set; }
        [Required]
        public int? CustomerId { get; set; }
      
        
    }
}
