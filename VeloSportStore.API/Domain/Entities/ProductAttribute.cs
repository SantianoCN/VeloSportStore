using System.Diagnostics.CodeAnalysis;
using VeloSportStore.API.Domain.Enums.Types;

namespace VeloSportStore.API.Domain.Entities
{
    public class ProductAttribute
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public ProductAttributeTypes ValueType { get; set; }
        public string Unit { get; set; } = string.Empty;
    }
}
