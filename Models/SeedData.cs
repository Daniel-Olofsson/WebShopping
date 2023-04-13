using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebShopping.Data;
using System;
using System.Linq;
using WebShopping.Models;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebShoppingContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<WebShoppingContext>>()))
        {
            // Look for any movies.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            context.Product.AddRange(
                new Product
                {
                    Name = "When Harry Met Sally",
                    Description = "harry-boy",
                    Price = 7.99M
                },
                new Product
                {
                    Name = "bnla bla bla",
                    Description = "hfsdfsdfsdarry-boy",
                    Price = 1.99M
                }
                
            );
            context.SaveChanges();
        }
    }
}