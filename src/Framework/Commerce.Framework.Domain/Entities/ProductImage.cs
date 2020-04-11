using System;

namespace Commerce.Domain.Entities
{
    public class ProductImage : Image
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}