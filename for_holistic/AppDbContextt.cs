using for_holistic.Models;
using Microsoft.EntityFrameworkCore;

namespace for_holistic
{
    public class AppDbContextt : DbContext
    {
        public AppDbContextt(DbContextOptions options) : base(options)
        {
        }
       public DbSet<Customerr> customerrs {  get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Productt> productts { get; set; }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }
    }
}
