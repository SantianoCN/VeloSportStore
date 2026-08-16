using Microsoft.EntityFrameworkCore;
using VeloSportStore.API.Domain.Contracts;
using VeloSportStore.API.Domain.Entities;
using VeloSportStore.API.Infrastructure.Database;

namespace VeloSportStore.API.Infrastructure.Repositories
{
    public class ProductRepository : DatabaseRepository<DataContext>, IProductRepository
    {
        public ProductRepository(
            DataContext context,
            ILogger<DatabaseRepository<DataContext>> logger
            ) : base(context, logger)
        {
        }

        public async Task CreateAsync(Product entity)
        {
            _context.Products.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid uuid)
        {
            _context.Products.Remove(new Product { Id = uuid });
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(Guid uuid)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == uuid);

            if (product == null)
            {
                throw new KeyNotFoundException($"Product with ID {uuid} not found.");
            }
            return product;
        }

        public async Task UpdateAsync(Guid uuid, Product entity)
        {
            var prduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == uuid);
            if (prduct == null)
            {
                throw new KeyNotFoundException($"Product with ID {uuid} not found.");
            }
            prduct.Name = entity.Name;
            prduct.Description = entity.Description;
            prduct.Price = entity.Price;
            prduct.CategoryId = entity.CategoryId;
            prduct.Tags = entity.Tags;

            _context.Products.Update(prduct);
            return _context.SaveChangesAsync();
        }
    }
}