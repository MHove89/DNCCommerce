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
                      new Product { Title = "Apples", Description ="this description is very cool" },
                        new Product { Title = "Milk",  Description ="this description is very cool" },
                        new Product { Title = "Bread",  Description ="this description is very cool"},
                        new Product { Title = "Toilet paper" , Description ="this description is very cool"},
                        new Product { Title = "Pasta", Description ="this description is very cool" },
                        new Product { Title = "Tissues" , Description ="this description is very cool"},
                        new Product { Title = "Tuna", Description ="this description is very cool" },
                        new Product { Title = "Water", Description ="this description is very cool" }
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
