using FinnApp.Data.Repository.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinnApp.Models
{
    public class Expense : BaseModel<int>
    {
        public decimal Ammount { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}
