using System.ComponentModel.DataAnnotations;


namespace ZenZygServer_API.Models.DTO
{
    public class TicketCreateDTO
    {
        [Required]
        public int? StoreId { get; set; }
        [Required]
        public int? CustomerId { get; set; }

    }
}
