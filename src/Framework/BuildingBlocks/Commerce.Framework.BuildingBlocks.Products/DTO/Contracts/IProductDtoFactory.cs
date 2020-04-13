using Commerce.Domain.Entities;

namespace Commerce.Framework.BuildingBlocks.Products.DTO.Contracts
{
    public interface IProductDtoFactory
    {
        ProductDto Create(Product product);
    }
}