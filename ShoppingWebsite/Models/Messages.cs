using ShoppingWebsite.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingWebsite.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        [ForeignKey("ApplicationUser")]
        [Display(Name = "UserId")]
        public string UserId { get; set; } = "-";
        public ApplicationUser? User { get; set; }
    }
}
