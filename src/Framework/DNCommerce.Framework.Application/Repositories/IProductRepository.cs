using DNCommerce.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNCommerce.Application.Repositories
{
    public interface IProductRepository
    {
        Task InsertProductAsync(Product product);
        Task<IList<Product>> GetAll();
        Task UpdateAsync(Product product);
        Task<Product> FindAsync(Guid guid);
    }
}
