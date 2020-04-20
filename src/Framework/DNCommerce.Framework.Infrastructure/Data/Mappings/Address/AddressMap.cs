using DNCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings.Products
{
    public partial class AddressMap : EntityMapConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable(nameof(Address));
            builder.HasKey(address => address.Id);
            
            builder.Property(address => address.FirstName).IsRequired().HasMaxLength(150);
            builder.Property(address => address.LastName).IsRequired().HasMaxLength(150);
        }
    }
}