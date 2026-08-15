namespace VeloSportStore.API.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ParentId { get; set; } = Guid.Empty;
        public Category? Parent { get; set; } = null;
        public ICollection<CategoriesAttributes> CategoryAttributes { get; set; }
            = new List<CategoriesAttributes>();
    }
}
