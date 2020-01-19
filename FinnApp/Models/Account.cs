using FinnApp.Data.Repository.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinnApp.Models
{
    public class Account: BaseModel<int>
    {
        public Account()
        {
            Expenses = new HashSet<Expense>();
        }
        
        public decimal Amount { get; set; }

        public string Name { get; set; }

        public virtual string PersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
