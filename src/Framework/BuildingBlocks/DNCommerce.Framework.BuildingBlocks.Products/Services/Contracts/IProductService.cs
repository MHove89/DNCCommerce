using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DNCommerce.Framework.BuildingBlocks.Products.DTO;

namespace DNCommerce.Framework.BuildingBlocks.Products.Services
{
    public interface IProductService
    {
        Task<IList<ProductDto>> GetProductByCategoryId(Guid categoryId);
        Task<ProductDto> GetProductById(Guid productId);
    }
}