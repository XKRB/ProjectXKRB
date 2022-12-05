using API.Models;
using Microsoft.EntityFrameworkCore;
// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Context.Context
{
    /// <summary>
    /// Product Context
    /// To connect to the database and query product's tables
    /// </summary>
    public class ProductContext : DbContext
    {
        /// <summary>
        /// To query Products table
        /// </summary>
        public DbSet<ProductModel> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        /// <summary>
        /// Apply entity type congigurations when the model is creating
        /// </summary>
        /// <param name="modelBuilder"> define entities</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ProductsEntityTypeConfiguration());
        }

        /// <summary>
        /// Enable Sensitive Data Logging
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
