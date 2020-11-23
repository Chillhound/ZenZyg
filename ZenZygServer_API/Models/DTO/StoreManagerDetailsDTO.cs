using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Models
{
    public class StoreManagerDetailsDTO
    {
        public int StoreManagerId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Email { get; set; }

        public int StoreId { get; set; }
    }
}