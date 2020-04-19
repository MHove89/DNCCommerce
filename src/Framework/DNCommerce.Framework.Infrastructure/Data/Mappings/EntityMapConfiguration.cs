using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DNCommerce.Domain.Entities;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings
{
    public partial class EntityMapConfiguration<TEntity> : IEntityMapConfiguration, IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
        }

        public virtual void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(this);
        }
    }
}