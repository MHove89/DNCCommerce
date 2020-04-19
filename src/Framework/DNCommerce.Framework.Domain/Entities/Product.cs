using System;
using System.Collections.Generic;

namespace DNCommerce.Domain.Entities
{
    public class Product : BaseEntity
    {

        private ICollection<ProductCategory> _productCategories;

        private ICollection<ProductImage> _productImages;

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Feature { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int OldPrice { get; set; }

        public int Weight { get; set; }

        public int QuantityInStock { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories
        {
            get => _productCategories ?? (_productCategories = new List<ProductCategory>());
            protected set => _productCategories = value;
        }

        public ICollection<ProductImage> ProductImages
        {
            get => _productImages ?? (_productImages = new List<ProductImage>());
            protected set => _productImages = value;
        }
    }
}
