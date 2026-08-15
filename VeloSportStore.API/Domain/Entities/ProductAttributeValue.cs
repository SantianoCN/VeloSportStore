
namespace VeloSportStore.API.Domain.Entities
{
    public class ProductAttributeValue
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid ProductAttributeId { get; set; }
        public ProductAttribute ProductAttribute { get; set; } 
        public string TextValue { get; set; }
        public decimal? NumericValue { get; set; }
        public bool? BooleanValue { get; set; }
        
    }
}