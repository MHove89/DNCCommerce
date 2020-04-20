using System;

namespace DNCommerce.Domain.Entities
{
    public class ProductImage : BaseEntity
    {
        public Guid ProductImageId { get; set; }

        public Guid ImageId { get; set; }

        public Image Image { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public int DisplayOrder { get; set; }
    }
}