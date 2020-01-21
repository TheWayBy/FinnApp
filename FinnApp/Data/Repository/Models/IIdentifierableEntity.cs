using System;

namespace FinnApp.Data.Repository.Models
{
    public interface IIdentifierableEntity
    {
        Guid Identifier { get; set; }
    }
}
