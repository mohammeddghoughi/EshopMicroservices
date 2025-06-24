using System.ComponentModel.DataAnnotations;

namespace Catalog.API.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Category> Category { get; set; } = new();
        public string Description { get; set; }
        public string ImageFile { get; set; }

        public decimal Price { get; set; }
    }
}
