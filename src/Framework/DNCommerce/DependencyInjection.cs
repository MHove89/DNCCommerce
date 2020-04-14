using DNCommerce.Application;
using DNCommerce.Framework.BuildingBlocks.Products;
using DNCommerce.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DNCommerce
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDNCommerce(this IServiceCollection collection, IConfiguration configuration)
        {
            collection.AddInfrastructure(configuration);
            collection.AddApplication();
            collection.AddBuildingBlocks(configuration);
            return collection;
        }
    }
}
