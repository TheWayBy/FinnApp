using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinnApp.Models
{
    public class Category
    {
        public Category()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category SubCategory { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
