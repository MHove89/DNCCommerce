using DNCommerce.Domain.Entities;
using DNCommerce.Framework.BuildingBlocks.Catalog.DTO.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace DNCommerce.Framework.BuildingBlocks.Catalog.DTO
{
    public class ProductDtoFactory : IProductDtoFactory
    {
        public ProductDto ProductDto(Product product)
        {
            throw new System.NotImplementedException();
        }

        public InsertProductDto InsertProductDto(string title, string description, string feature, int price)
        {
            return new InsertProductDto
            {
                Title = title,
                Description = description,
                Feature = feature,
                Price = price
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

        public UpdateProductDto UpdateProductDto(string title, string description, string feature, int price)
        {
            throw new System.NotImplementedException();
        }
    }
}