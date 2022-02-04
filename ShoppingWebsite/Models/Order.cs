using ShoppingWebsite.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingWebsite.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Address { get; set; }   

        public int HouseNr { get; set; }

        public string Gemeente { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
        [ForeignKey("ApplicationUser")]
        [Display(Name = "UserId")]
        public string UserId { get; set; } = "-";
        public ApplicationUser? User { get; set; }
        [Display(Name = "Products")]
        public List<Product>? Products { get; set; } 

        
    }
}
