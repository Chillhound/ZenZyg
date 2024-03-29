using System.ComponentModel.DataAnnotations;
using ZenZygServer_API.Entities;

namespace ZenZygServer_API.Models
{
    public class StoreCreateDTO
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int? StoreManagerId { get; set; }

        [Required]
        public double Size { get; set; }

        [Required]
        public string Address { get; set; }
    }
}