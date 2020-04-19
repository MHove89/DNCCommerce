using DNCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings.Products
{
    public partial class BillingAddressMap : EntityMapConfiguration<BillingAddress>
    {
        public override void Configure(EntityTypeBuilder<BillingAddress> builder)
        {
            builder.ToTable(nameof(BillingAddress));
            builder.HasKey(billingAddress => billingAddress.Id);
            
            builder.Property(billingAddress => billingAddress.FirstName).IsRequired().HasMaxLength(150);
            builder.Property(billingAddress => billingAddress.LastName).IsRequired().HasMaxLength(150);
        }
    }
}