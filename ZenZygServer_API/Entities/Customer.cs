using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int PhoneNumber { get; set; }
    }
    
}