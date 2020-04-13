using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Commerce.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
