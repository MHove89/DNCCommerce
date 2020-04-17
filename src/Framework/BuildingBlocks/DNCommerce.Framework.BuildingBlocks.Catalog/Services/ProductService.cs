using System.Threading.Tasks;
using DNCommerce.Application.Repositories;
using DNCommerce.Framework.BuildingBlocks.Catalog.DTO;
using DNCommerce.Domain.Entities;
using DNCommerce.Framework.BuildingBlocks.Catalog.DTO.Contracts;

namespace DNCommerce.Framework.BuildingBlocks.Catalog.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductDtoFactory _productDtoFactory;
        private readonly IProductRepository _productRepository;

        public ProductService(IProductDtoFactory productDtoFactory, IProductRepository productRepository)
        {
            _productDtoFactory = productDtoFactory;
            _productRepository = productRepository;
        }

        public async Task InsertProductAsync(InsertProductDto insertProductDto)
        {
            var product = new Product()
            {
                Title = insertProductDto.Title,
                Description = insertProductDto.Description,
                Feature = insertProductDto.Feature,
                Price = insertProductDto.Price,
            };

            await _productRepository.InsertProductAsync(product);
        }

        public async Task<ProductListDto> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAll();
            var productListDto = _productDtoFactory.ProductListDto(products);
            return productListDto;
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var product = await _productRepository.FindAsync(updateProductDto.Id);

            product.Title = updateProductDto.Title;
            product.Feature = updateProductDto.Feature;
            product.Description = updateProductDto.Description;
            product.Price = updateProductDto.Price;

            await _productRepository.UpdateAsync(product);
        }
    }
}