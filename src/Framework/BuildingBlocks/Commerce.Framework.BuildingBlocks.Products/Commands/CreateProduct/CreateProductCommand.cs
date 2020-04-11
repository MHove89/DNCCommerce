using System;
using MediatR;

namespace Commerce.Framework.BuildingBlocks.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Feature { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
