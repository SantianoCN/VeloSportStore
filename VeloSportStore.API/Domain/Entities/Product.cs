
using VeloSportStore.API.Domain.Entities;

namespace VeloSportStore.API.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public Money Price { get; set; }
        public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
}
