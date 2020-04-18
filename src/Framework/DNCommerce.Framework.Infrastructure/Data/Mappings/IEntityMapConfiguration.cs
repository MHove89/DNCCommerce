using Microsoft.EntityFrameworkCore;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings
{
    public interface IEntityMapConfiguration
    {
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}