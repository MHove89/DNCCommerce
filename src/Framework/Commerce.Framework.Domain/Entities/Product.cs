using System;
using System.Collections.Generic;

namespace Commerce.Domain.Entities
{
    public class Product : BaseEntitiy
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Feature { get; set; }
        public string Description { get; set; }
        public string Src { get; set; }
        public List<ProductImage> Images { get; set; }
        public int Price { get; set; }
    }
}
