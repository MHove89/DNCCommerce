using DNCommerce.Domain.Entities;
using DNCommerce.Framework.BuildingBlocks.Catalog.DTO.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DNCommerce.Framework.BuildingBlocks.Catalog.DTO
{
    public class ProductDtoFactory : IProductDtoFactory
    {
        public ProductDto ProductDto(Product product)
        {
            return new ProductDto
            {
                Name = product.Name,
                Feature = product.Feature,
                Description = product.Description,
                Price = product.Price,
                QuantityInStock = product.QuantityInStock,
                Weight = product.Weight
            };
        }

        public InsertProductDto InsertProductDto(string name, string feature, string description, int price, int quantityInStock, int weight)
        {
            return new InsertProductDto
            {
                Name = name,
                Feature = feature,
                Description = description,
                Price = price,
                QuantityInStock = quantityInStock,
                Weight = weight
            };
        }

        public ProductListDto ProductListDto(IList<Product> products)
        {
            var productDtos = products.Select(p => ProductDto(p)).ToList();

            return new ProductListDto
            {
                ProductDtos = productDtos
            };
        }

        public UpdateProductDto UpdateProductDto(Guid id, string name, string feature, string description, int price, int quantityInStock, int weight)
        {
            return new UpdateProductDto
            {
                Id = id,
                Name = name,
                Feature = feature,
                Description = description,
                Price = price,
                QuantityInStock = quantityInStock,
                Weight = weight
            };
        }
    }
}