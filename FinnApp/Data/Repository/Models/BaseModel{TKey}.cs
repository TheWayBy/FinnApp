using System;
using System.ComponentModel.DataAnnotations;

namespace FinnApp.Data.Repository.Models
{
    public abstract class BaseModel<TKey> : IDeletableEntity, IIdentifierableEntity
    {
        [Key]
        public TKey Id { get; set; }

        public Guid Identifier { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
