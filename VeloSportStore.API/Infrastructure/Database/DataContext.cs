using Microsoft.EntityFrameworkCore;
using VeloSportStore.API.Domain.Entities;

namespace VeloSportStore.API.Infrastructure.Database
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<CategoriesAttributes> CategoryAttributes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
    }
}
