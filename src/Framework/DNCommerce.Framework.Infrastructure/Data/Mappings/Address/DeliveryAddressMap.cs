using DNCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings.Products
{
    public partial class DeliveryAddressMap : EntityMapConfiguration<DeliveryAddress>
    {
        public override void Configure(EntityTypeBuilder<DeliveryAddress> builder)
        {
            builder.ToTable(nameof(DeliveryAddress));
            builder.HasKey(deliveryAddress => deliveryAddress.Id);

            builder.Property(deliveryAddress => deliveryAddress.FirstName).IsRequired().HasMaxLength(150);
            builder.Property(deliveryAddress => deliveryAddress.LastName).IsRequired().HasMaxLength(150);
        }
    }
}