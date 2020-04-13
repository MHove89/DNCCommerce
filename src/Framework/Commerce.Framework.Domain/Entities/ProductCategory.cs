using System;

namespace Commerce.Domain.Entities
{
    public class ProductCategory : BaseEntitiy
    {
        public Guid Id { get; set; }
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}