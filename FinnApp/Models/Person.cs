using FinnApp.Data.Repository.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace FinnApp.Models
{
    public class Person : IdentityUser, IDeletableEntity
    {
        public Person()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();

            Acounts = new HashSet<Account>();
        }

        public string Name { get; set; }

        public virtual ICollection<Account> Acounts { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
