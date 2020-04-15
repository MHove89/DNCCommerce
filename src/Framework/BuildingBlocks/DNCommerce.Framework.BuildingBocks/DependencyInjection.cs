using DNCommerce.Framework.BuildingBlocks.Catalog;
using Microsoft.Extensions.DependencyInjection;

namespace DNCommerce.Framework.BuildingBlocks
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBuildingBlocks(this IServiceCollection services)
        {
            services.AddBuildingBlocksCatalog();
            return services;
        }
    }
}