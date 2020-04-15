using DNCommerce.Application.Repositories;
using DNCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNCommerce.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<Product> FindAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task InsertProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
