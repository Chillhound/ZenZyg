namespace ZenZygServer_API.Models
{
    public class StoreUpdateDTO : StoreCreateDTO
    {
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