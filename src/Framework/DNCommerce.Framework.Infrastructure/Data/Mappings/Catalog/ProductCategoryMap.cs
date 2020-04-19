using DNCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings.Catalog
{
    public partial class ProductCategoryMap : EntityMapConfiguration<ProductCategory>
    {
        public override void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable(nameof(ProductCategory));

            builder.HasOne(productCategory => productCategory.Category)
                .WithMany()
                .HasForeignKey(productCategory => productCategory.CategoryId)
                .IsRequired();

            builder.HasOne(productCategory => productCategory.Product)
                .WithMany(product => product.ProductCategories)
                .HasForeignKey(productCategory => productCategory.ProductId)
                .IsRequired();

            base.Configure(builder);
        }
    }
}