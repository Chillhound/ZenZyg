using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Models
{
    public class StoreManagerUpdateDTO : StoreManagerCreateDTO
    {

        public int StoreManagerId { get; set; }

        
    }
}