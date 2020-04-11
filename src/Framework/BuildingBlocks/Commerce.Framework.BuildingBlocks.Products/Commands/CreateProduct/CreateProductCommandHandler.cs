using Commerce.Application;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Commerce.Framework.BuildingBlocks.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, long>
    {
        private IApplicationDbContext _applicationDbContext;

        public CreateProductCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<long> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _applicationDbContext.Products.Add(new Domain.Entities.Product());
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return 1000;
        }
    }
}
