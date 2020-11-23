using System.ComponentModel.DataAnnotations;
using ZenZygServer_API.Entities;

namespace ZenZygServer_API.Models
{
    public class StoreDetailsDTO
    {
        public int StoreId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public StoreManager StoreManagerId { get; set; }

        [Required]
        public double Size { get; set; }

        [Required]
        public string Address { get; set; }
    }
}