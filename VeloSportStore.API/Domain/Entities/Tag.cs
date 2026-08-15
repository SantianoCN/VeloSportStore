using VeloSportStore.API.Domain;

namespace VeloSportStore.API.Domain.Entities
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Tagname { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
