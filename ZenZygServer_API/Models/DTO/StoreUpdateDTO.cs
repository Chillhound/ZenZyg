using System.ComponentModel.DataAnnotations;
using ZenZygServer_API.Entities;


namespace ZenZygServer_API.Models
{
    public class StoreUpdateDTO : StoreCreateDTO
    {
        [Required]
        public int StoreId { get; set; }

       
       
    }
}