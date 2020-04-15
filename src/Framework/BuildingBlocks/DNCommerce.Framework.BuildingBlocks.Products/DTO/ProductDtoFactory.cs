using DNCommerce.Domain.Entities;
using DNCommerce.Framework.BuildingBlocks.Products.DTO.Contracts;

namespace DNCommerce.Framework.BuildingBlocks.Products.DTO
{
    public class ProductDtoFactory : IProductDtoFactory
    {
        public ProductDto Create(Product product)
        {
            return new ProductDto
            {
                Title = product.Title,
                Description = product.Description,
                Feature = product.Feature,
                Price = product.Price
            };
        }
    }
}