using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Name",
                Price = new decimal(12.3),
                Description = "Description",
                ImageUrl = "https://www.climba.com.br/blog/wp-content/uploads/2018/12/259186-retirar-o-produto-na-loja-fisica-o-novo-diferencial-do-ecommerce.png",
                Category = "Category"
            });
        }
    }
}
