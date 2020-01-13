using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinnApp.Models
{
    public class Person
    {
        public Person()
        {
            Acounts = new HashSet<Account>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Account> Acounts { get; set; }

    }
}
