using Microsoft.EntityFrameworkCore;
using Shop.Entities;

namespace Shop
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            
        }
    }
}
