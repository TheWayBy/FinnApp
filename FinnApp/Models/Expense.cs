using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinnApp.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        public decimal Ammount { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public int SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public virtual Category SubCategory { get; set; }

        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}
