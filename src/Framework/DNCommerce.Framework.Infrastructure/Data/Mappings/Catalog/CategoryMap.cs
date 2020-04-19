using DNCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings.Catalog
{
    public partial class CategoryMap : EntityMapConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(nameof(Category));
            builder.HasKey(category => category.Id);

            builder.Property(category => category.Title).IsRequired().HasMaxLength(400);

            base.Configure(builder);
        }
    }
}