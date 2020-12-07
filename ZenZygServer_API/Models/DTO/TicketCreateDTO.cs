using System.ComponentModel.DataAnnotations;


namespace ZenZygServer_API.Models
{
    public class TicketCreateDTO
    {
        [Required]
        public int? StoreId { get; set; }
        [Required]
        public int? CustomerId { get; set; }

    }
}
