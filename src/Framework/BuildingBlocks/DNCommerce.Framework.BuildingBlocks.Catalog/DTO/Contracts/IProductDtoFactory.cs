using DNCommerce.Domain.Entities;
using System.Collections.Generic;

namespace DNCommerce.Framework.BuildingBlocks.Catalog.DTO.Contracts
{
    public interface IProductDtoFactory
    {
        ProductDto ProductDto(Product product);
        InsertProductDto InsertProductDto(string title, string description, string feature, int price);
        ProductListDto ProductListDto(IList<Product> products);
        UpdateProductDto UpdateProductDto(string title, string description, string feature, int price);
    }
}