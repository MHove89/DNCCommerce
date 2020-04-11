using MediatR;

namespace Commerce.Framework.BuildingBlocks.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<long>
    {
        public string Title { get; set; }
        public string Feature { get; set; }
        public string Description { get; set; }
        public string Src { get; set; }
        public int Price { get; set; }
    }
}
