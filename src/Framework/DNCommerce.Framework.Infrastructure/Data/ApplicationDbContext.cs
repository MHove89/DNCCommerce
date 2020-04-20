using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DNCommerce.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;
using DNCommerce.Framework.Application.Services;
using System.Reflection;
using System.Linq;
using DNCommerce.Framework.Infrastructure.Data.Mappings;

namespace DNCommerce.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        private readonly ICurrentUserService _currentUserService;

        public ApplicationDbContext(DbContextOptions options, ICurrentUserService currentUserService) : base(options)
        {
            _currentUserService = currentUserService;
        }

        public virtual DbSet<Address> Address { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderLine> OrderLines { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<ProductImage> ProductImages { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var typeConfigurations = Assembly.GetExecutingAssembly().GetTypes().Where(type =>
                (type.BaseType?.IsGenericType ?? false)
                    && (type.BaseType.GetGenericTypeDefinition() == typeof(EntityMapConfiguration<>)
                        || type.BaseType.GetGenericTypeDefinition() == typeof(EntityMapConfiguration<>)));

            foreach (var typeConfiguration in typeConfigurations)
            {
                var configuration = (IEntityMapConfiguration)Activator.CreateInstance(typeConfiguration);
                configuration.ApplyConfiguration(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
