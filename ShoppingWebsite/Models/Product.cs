using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingWebsite.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public string? ImagePath { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public List<Order>? orders { get; set; }
        
    }
}
