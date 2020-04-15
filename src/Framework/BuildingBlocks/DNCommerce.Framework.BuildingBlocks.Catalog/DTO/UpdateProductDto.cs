﻿using System;

namespace DNCommerce.Framework.BuildingBlocks.Catalog.DTO
{
    public class UpdateProductDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Feature { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }
    }
}