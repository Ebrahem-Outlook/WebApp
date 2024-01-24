using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName ="navrchar(50)")]
        public String Title { get; set; }

        [Column(TypeName = "navrchar(5)")]
        public String Icon { get; set; } = "";

        [Column(TypeName ="navrchar(10)")]
        public String Type { get; set; }
    }
}
