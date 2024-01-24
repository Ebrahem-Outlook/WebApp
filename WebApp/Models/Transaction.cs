using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //CategoryId
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "navrchar(75)")]
        public String? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
