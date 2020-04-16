using DNCommerce.Admin.Areas.Admin.Controllers;
using DNCommerce.Application;
using DNCommerce.Framework.BuildingBlocks;
using DNCommerce.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DNCommerce
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDNCommerce(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddInfrastructure(configuration);
            services.AddApplication();
            services.AddBuildingBlocks();
            services.AddMvc();
            services.AddMvc().AddApplicationPart(typeof(AdminController).Assembly).AddControllersAsServices();
            return services;
        }
    }
}
