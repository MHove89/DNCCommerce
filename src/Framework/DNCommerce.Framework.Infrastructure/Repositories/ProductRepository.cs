using DNCommerce.Application.Repositories;
using DNCommerce.Domain.Entities;
using DNCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNCommerce.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
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
            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                // TODO : Create nice exceptions
                throw;
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
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
