using DNCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings.Catalog
{
    public partial class ProductImageMap : EntityMapConfiguration<ProductImage>
    {
        public override void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable(nameof(ProductImage));

            builder.HasOne(productImage => productImage.Image)
                .WithMany()
                .HasForeignKey(productImage => productImage.ImageId)
                .IsRequired();

            builder.HasOne(productImage => productImage.Product)
                .WithMany(product => product.ProductImages)
                .HasForeignKey(productImage => productImage.ProductId)
                .IsRequired();

            base.Configure(builder);
        }
    }
}