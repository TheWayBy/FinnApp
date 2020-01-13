using System.ComponentModel.DataAnnotations;

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

        // todo: sk_sub_category
    }
}
