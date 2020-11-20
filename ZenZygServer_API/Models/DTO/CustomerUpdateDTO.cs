namespace ZenZygServer_API.Models
{
    public class CustomerUpdateDTO : CustomerCreateDTO
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int PhoneNumber { get; set; }
    }
}