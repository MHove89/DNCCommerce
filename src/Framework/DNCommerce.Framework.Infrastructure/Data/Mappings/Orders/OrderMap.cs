using DNCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings.Orders
{
    public partial class OrderMap : EntityMapConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(nameof(Order));
            builder.HasKey(order => order.Id);

            builder.Property(order => order.OrderNumber).IsRequired();
            builder.Property(order => order.OrderTotal).IsRequired();
            builder.Property(order => order.PaymentTotal).IsRequired();
            builder.Property(order => order.TaxTotal).IsRequired();
            builder.Property(order => order.SubTotal).IsRequired();
            builder.Property(order => order.Note).IsRequired().HasMaxLength(1000);

            builder.HasOne(order => order.BillingAddress)
                          .WithMany()
                          .HasForeignKey(order => order.BillingAddressId)
                          .IsRequired()
                          .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(order => order.DeliveryAddress)
                          .WithMany()
                          .HasForeignKey(order => order.DeliveryAddressId)
                          .IsRequired();

            base.Configure(builder);
        }
    }
}