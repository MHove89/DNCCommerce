using DNCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings.Products
{
    public partial class AddressMap : EntityMapConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Name).IsRequired();
            builder.Property(product => product.Feature).HasMaxLength(400);
            builder.Property(product => product.Description).IsRequired();
            builder.Property(product => product.Price).HasColumnType("decimal(18, 4)");
            builder.Property(product => product.OldPrice).HasColumnType("decimal(18, 4)");

            base.Configure(builder);
        }
    }
}