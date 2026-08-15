

using Microsoft.EntityFrameworkCore;

namespace VeloSportStore.API.Infrastructure.Database
{
    public abstract class DatabaseRepository<DatabaseContext> where DatabaseContext : DbContext
    {
        protected DatabaseContext _context;
        protected ILogger<DatabaseRepository<DatabaseContext>> _logger;
        public DatabaseRepository(
            DatabaseContext context, 
            ILogger<DatabaseRepository<DatabaseContext>> logger
        ) => (_context, _logger) = (context, logger);
    }
}