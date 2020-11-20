namespace ZenZygServer_API.Models
{
    public class StoreManagerCreateDTO
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Email { get; set; }
    }
}