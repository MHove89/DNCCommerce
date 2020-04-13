
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Commerce.Framework.BuildingBlocks.Products
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