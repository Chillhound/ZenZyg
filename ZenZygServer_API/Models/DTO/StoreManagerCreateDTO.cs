using System.ComponentModel.DataAnnotations;
using ZenZygServer_API.Entities;

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