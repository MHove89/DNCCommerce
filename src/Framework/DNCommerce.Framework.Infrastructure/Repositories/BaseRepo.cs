using System;
using System.Linq;
using DNCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DNCommerce.Framework.Infrastructure.Repositories
{
    public abstract class BaseRepo
    {
        private ApplicationDbContext _context;

        protected BaseRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        protected string GetFullErrorTextAndRollbackEntityChanges(DbUpdateException exception)
        {
            //rollback entity changes
            if (_context is ApplicationDbContext dbContext)
            {
                var entries = dbContext.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified).ToList();

                entries.ForEach(entry =>
                {
                    try
                    {
                        entry.State = EntityState.Unchanged;
                    }
                    catch (InvalidOperationException)
                    {
                        // ignored
                    }
                });
            }

            try
            {
                _context.SaveChanges();
                return exception.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}