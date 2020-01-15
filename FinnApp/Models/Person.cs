using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinnApp.Models
{
    public class Person : IdentityUser
    {
        public Person()
        {
            Acounts = new HashSet<Account>();
        }

        public string Name { get; set; }

        public virtual ICollection<Account> Acounts { get; set; }
    }
}
