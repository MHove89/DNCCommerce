using DNCommerce.Framework.BuildingBlocks.Catalog.DTO;
using DNCommerce.Framework.BuildingBlocks.Catalog.DTO.Contracts;
using DNCommerce.Framework.BuildingBlocks.Catalog.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DNCommerce.Framework.BuildingBlocks.Catalog
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBuildingBlocksCatalog(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductDtoFactory, ProductDtoFactory>();
            return services;
        }
    }
}