using System.ComponentModel.DataAnnotations;

namespace ZenZygServer_API.Models
{
    public class CustomerUpdateDTO : CustomerCreateDTO
    {
        public int CustomerId { get; set; }

       
    }
}