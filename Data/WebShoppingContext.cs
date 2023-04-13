using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebShopping.Models;

namespace WebShopping.Data
{
    public class WebShoppingContext : DbContext
    {
        public WebShoppingContext (DbContextOptions<WebShoppingContext> options)
            : base(options)
        {
        }

        public DbSet<WebShopping.Models.Product> Product { get; set; } = default!;
    }
}
