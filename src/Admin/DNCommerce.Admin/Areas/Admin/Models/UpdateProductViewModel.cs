using System;

namespace DNCommerce.Admin.Areas.Admin.Models
{
    public class UpdateProductViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; internal set; }

        public string Description { get; set; }

        public string Feature { get; internal set; }

        public int Price { get; internal set; }
        public int QuantityInStock { get; internal set; }
        public int Weight { get; internal set; }
    }
}