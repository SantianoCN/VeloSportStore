namespace VeloSportStore.API.Domain
{
    public class ProductImage
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderIndex { get; set; }
        public string Url { get; set; }
    }
}
