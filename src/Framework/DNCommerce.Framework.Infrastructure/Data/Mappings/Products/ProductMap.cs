using DNCommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNCommerce.Framework.Infrastructure.Data.Mappings.Products
{
    public class ProductMap : EntityMapConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<ProductMap> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}