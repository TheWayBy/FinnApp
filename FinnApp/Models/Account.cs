using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinnApp.Models
{
    public class Account
    {
        public Account()
        {
            Expenses = new HashSet<Expense>();
        }

        [Key]
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public string Name { get; set; }

        public virtual int PersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
