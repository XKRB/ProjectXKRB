using API.Services.Clases;
using Microsoft.EntityFrameworkCore;
// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Context
{
    /// <summary>
    /// Product Context
    /// To connect to the database and query user's tables
    /// </summary>
    public class ProductContext : DbContext
    {

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        /// <summary>
        /// To query Products table
        /// </summary>
        public DbSet<ProductItem> ProductItems { get; set; } = null!;
    }
}
