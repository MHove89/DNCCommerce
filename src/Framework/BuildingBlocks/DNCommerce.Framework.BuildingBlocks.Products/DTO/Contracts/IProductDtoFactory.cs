using DNCommerce.Domain.Entities;

namespace DNCommerce.Framework.BuildingBlocks.Products.DTO.Contracts
{
    public interface IProductDtoFactory
    {
        ProductDto Create(Product product);
    }
}