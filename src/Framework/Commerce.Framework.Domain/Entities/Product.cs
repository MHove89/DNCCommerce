﻿using System;
using System.Collections.Generic;

namespace Commerce.Domain.Entities
{
    public class Product : BaseEntitiy
    {
        public Product()
        {
            ProductImages = new List<ProductImage>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Feature { get; set; }
        public string Description { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public int Price { get; set; }
    }
}