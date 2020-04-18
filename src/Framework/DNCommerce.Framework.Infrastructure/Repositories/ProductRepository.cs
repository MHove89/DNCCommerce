using DNCommerce.Application.Repositories;
using DNCommerce.Domain.Entities;
using DNCommerce.Framework.Infrastructure.Repositories;
using DNCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNCommerce.Infrastructure.Repositories
{
    public class ProductRepository : BaseRepo, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Product> FindAsync(Guid id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IList<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task InsertProductAsync(Product product)
        {

            if (product == null)
                throw new ArgumentNullException(nameof(product));

            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(GetFullErrorTextAndRollbackEntityChanges(ex));
            }
        }

        public async Task UpdateAsync(Product product)
        {
            try
            {
                var dao = await _context.Products.FindAsync(product.Id);
                dao.Title = product.Title;
                dao.Description = product.Description;
                dao.Feature = product.Feature;
                dao.Price = product.Price;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(GetFullErrorTextAndRollbackEntityChanges(ex));
            }
        }
    }
}
