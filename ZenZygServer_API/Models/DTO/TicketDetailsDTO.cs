using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Models.DTO
{
    public class TicketDetailsDTO
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
