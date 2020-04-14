using DNCommerce.Application;
using DNCommerce.Domain.Entities;
using DNCommerce.Framework.BuildingBlocks.Products.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using DNCommerce.Framework.BuildingBlocks.Products.DTO.Contracts;

namespace DNCommerce.Framework.BuildingBlocks.Products.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IProductDtoFactory _productDtoFactory;

        public ProductService(IRepository<Product> productRepository, IProductDtoFactory productDtoFactory)
        {
            _productRepository = productRepository;
            _productDtoFactory = productDtoFactory;
        }

        public async Task<IList<ProductDto>> GetProductByCategoryId(Guid categoryId)
        {
            var products = await _productRepository.FindAllAsync(p => p.ProductCategories.Any(p => p.Id == categoryId));
            return products?.Select(p => _productDtoFactory.Create(p)).ToList();
        }

        public async Task<ProductDto> GetProductById(Guid productId)
        {
            var product = await _productRepository.GetAsync(productId);
            return _productDtoFactory.Create(product);
        }
    }
}