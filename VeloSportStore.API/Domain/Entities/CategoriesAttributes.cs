using Microsoft.EntityFrameworkCore;
using VeloSportStore.API.Domain.Entities;

namespace VeloSportStore.API.Domain.Entities
{
    public class CategoriesAttributes
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid ProductAttributeId { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
        public bool IsRequired { get; set; } = false;
        public bool Inheritance { get; set; } = true;
    }
}