using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Entities
{
    public class StoreManager
    {
        public int StoreManagerId { get; set; }

        public int StoreId { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }
    }
}