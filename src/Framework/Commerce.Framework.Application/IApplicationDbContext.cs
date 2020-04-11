using Microsoft.EntityFrameworkCore;
using Commerce.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;

namespace Commerce.Application
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<ProductImage> Images { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
