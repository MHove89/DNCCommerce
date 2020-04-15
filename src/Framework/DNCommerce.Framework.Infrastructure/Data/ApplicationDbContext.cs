using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DNCommerce.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;
using DNCommerce.Framework.Application.Services;

namespace DNCommerce.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        private readonly ICurrentUserService _currentUserService;

        public ApplicationDbContext(DbContextOptions options, ICurrentUserService currentUserService) : base(options)
        {
            _currentUserService = currentUserService;
        }

        public virtual DbSet<BillingAddress> BillingAddresses { get; set; }

        public virtual DbSet<DeliveryAddress> DeliveryAddresses { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderLine> OrderLines { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<ProductImage> ProductImages { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntitiy>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = DateTime.UtcNow;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
