using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Models
{
    public class StoreManagerCreateDTO
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }

        public int StoreId { get; set; }
    }
}