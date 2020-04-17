using System.Collections.Generic;
using DNCommerce.Framework.BuildingBlocks.Catalog.DTO;

namespace DNCommerce.Admin.Areas.Admin.Models
{
    public class ProductListViewModel
    {
        public IList<ProductDto> Products { get; set; }
    }
}