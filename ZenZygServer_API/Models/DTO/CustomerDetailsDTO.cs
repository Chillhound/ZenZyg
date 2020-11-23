using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Models
{
    public class CustomerDetailsDTO
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int PhoneNumber { get; set; }
    }
}