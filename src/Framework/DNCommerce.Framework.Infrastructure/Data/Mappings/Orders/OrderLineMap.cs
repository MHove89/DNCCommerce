using DNCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings.Orders
{
    public partial class OrderLineMap : EntityMapConfiguration<OrderLine>
    {
        public override void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.ToTable(nameof(OrderLine));
            builder.HasKey(orderLine => orderLine.Id);

            builder.Property(orderLine => orderLine.Amount).HasColumnType("decimal(18, 4)");
            builder.Property(orderLine => orderLine.Price).HasColumnType("decimal(18, 4)");

            builder.HasOne(orderLine => orderLine.Order)
             .WithMany(orderLine => orderLine.OrderLines)
             .HasForeignKey(orderItem => orderItem.OrderId)
             .IsRequired();

            base.Configure(builder);
        }
    }
}