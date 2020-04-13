using Commerce.Framework.BuildingBlocks.Products.DTO;
using Commerce.Framework.BuildingBlocks.Products.DTO.Contracts;
using Commerce.Framework.BuildingBlocks.Products.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Commerce.Framework.BuildingBlocks.Products
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