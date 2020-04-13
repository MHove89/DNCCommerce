using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commerce.Framework.BuildingBlocks.Products.DTO;

namespace Commerce.Framework.BuildingBlocks.Products.Services
{
    public interface IProductService
    {
        Task<IList<ProductDto>> GetProductByCategoryId(Guid categoryId);
        Task<ProductDto> GetProductById(Guid productId);
    }
}