using System.ComponentModel.DataAnnotations;

namespace Exercise2.Models
{
    public class Categories
    {
        [Key]
        public string? CategoryId { get; set; }
        public string? Name { get; set; }
    }
}
