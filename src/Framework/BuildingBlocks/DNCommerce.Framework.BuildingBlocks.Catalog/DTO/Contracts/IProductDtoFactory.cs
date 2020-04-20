using DNCommerce.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DNCommerce.Framework.BuildingBlocks.Catalog.DTO.Contracts
{
    public interface IProductDtoFactory
    {
        ProductDto ProductDto(Product product);
        InsertProductDto InsertProductDto(string name, string description, string feature, int price, int quantityInStock, int weight);
        ProductListDto ProductListDto(IList<Product> products);
        UpdateProductDto UpdateProductDto(Guid id, string name, string feature, string description, int price, int quantityInStock, int weight);
    }
}