using Microsoft.EntityFrameworkCore;
using Commerce.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;

namespace Commerce.Application
{
    public interface IApplicationDbContext
    {
        DbSet<BillingAddress> BillingAddresses { get; set; }
        DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderLine> OrderLines { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductImage> ProductImages { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
