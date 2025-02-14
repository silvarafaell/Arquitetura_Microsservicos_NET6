using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adiciona na base de dados
            modelBuilder.Entity<Product>().HasData(new Product
            { 
                Id = 2,
                Name = "Name",
                Price = new decimal(69.9),
                Description = "Description",
                ImageURL = "ImageURL",
                CategoryName = "CategoryName"
            });
        }
    }
}
