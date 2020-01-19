using FinnApp.Data.Repository.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace FinnApp.Models
{
    public class ApplicationRole : IdentityRole, IDeletableEntity
    {
        public ApplicationRole()
            : this(null)
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}