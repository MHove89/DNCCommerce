using Commerce.Application;
using Commerce.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Commerce.Framework.BuildingBlocks.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private IApplicationDbContext _applicationDbContext;

        public CreateProductCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(){
                 Description = request.Description,
                 Title = request.Title,
                 Feature = request.Feature,
                 Price = request.Price
            };
            
            _applicationDbContext.Products.Add(product);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            
            return product.Id;
        }
    }
}
