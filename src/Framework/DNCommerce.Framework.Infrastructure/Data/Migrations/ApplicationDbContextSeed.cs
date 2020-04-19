using Microsoft.AspNetCore.Identity;
using DNCommerce.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNCommerce.Infrastructure.Data.Migrations
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            // Seed, if necessary
            if (!context.Products.Any())
            {
                context.Products.AddRange(new List<Product>
                {
                      new Product { Name = "Apples", Description ="this description is very cool" },
                        new Product { Name = "Milk",  Description ="this description is very cool" },
                        new Product { Name = "Bread",  Description ="this description is very cool"},
                        new Product { Name = "Toilet paper" , Description ="this description is very cool"},
                        new Product { Name = "Pasta", Description ="this description is very cool" },
                        new Product { Name = "Tissues" , Description ="this description is very cool"},
                        new Product { Name = "Tuna", Description ="this description is very cool" },
                        new Product { Name = "Water", Description ="this description is very cool" }
                });
            }

            // Create default administrator
            var defaultUser = new IdentityUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, "Administrator1!");
            }
        }
    }
}
