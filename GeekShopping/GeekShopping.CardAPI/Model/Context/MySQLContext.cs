using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CardAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Product> CartHeders { get; set; }

    }
}
