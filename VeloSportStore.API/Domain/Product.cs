namespace VeloSportStore.API.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
        public string Properties { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Money Price { get; set; }
        public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();
        public ICollection<ProductTags> ProductTags { get; set; } = new List<ProductTags>();
        public ICollection<Tag> RelatedTags { get; set; } = new List<Tag>();
    }
}
