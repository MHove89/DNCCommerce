using Commerce.Domain.Entities;
using Commerce.Framework.BuildingBlocks.Products.DTO.Contracts;

namespace Commerce.Framework.BuildingBlocks.Products.DTO
{
    public class ProductDtoFactory : IProductDtoFactory
    {
        public ProductDto Create(Product product)
        {
            return new ProductDto
            {
            };
        }
    }
}