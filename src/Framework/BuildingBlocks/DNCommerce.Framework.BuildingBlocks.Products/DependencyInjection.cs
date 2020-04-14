using DNCommerce.Framework.BuildingBlocks.Products.DTO;
using DNCommerce.Framework.BuildingBlocks.Products.DTO.Contracts;
using DNCommerce.Framework.BuildingBlocks.Products.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DNCommerce.Framework.BuildingBlocks.Products
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBuildingBlocksProducts(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductDtoFactory, ProductDtoFactory>();
            return services;
        }
    }
}