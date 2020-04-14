using DNCommerce.Framework.BuildingBlocks.Products.DTO;
using DNCommerce.Framework.BuildingBlocks.Products.DTO.Contracts;
using DNCommerce.Framework.BuildingBlocks.Products.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DNCommerce.Framework.BuildingBlocks.Products
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBuildingBlocks(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBuildingBlocksProducts();
            return services;
        }
    }
}