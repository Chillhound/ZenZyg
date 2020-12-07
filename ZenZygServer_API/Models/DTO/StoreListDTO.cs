using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Models
{
    public class StoreListDTO {
        public int StoreId { get; set; }
        
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