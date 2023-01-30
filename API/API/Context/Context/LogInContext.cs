using API.Context.EntityConfiguration;
using API.Models;
using Microsoft.EntityFrameworkCore;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Context.Context;

/// <summary>
/// LogIn Context
/// </summary>
public class LogInContext:DbContext
{
    /// <summary>
    /// To query Products table
    /// </summary>
    public DbSet<LogInModel> LogIns { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public LogInContext(DbContextOptions<LogInContext> options): base(options)
    {
    }

    /// <summary>
    /// Apply entity type congigurations when the model is creating
    /// </summary>
    /// <param name="modelBuilder"> define entities</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder.ApplyConfiguration(new LogInEntityTypeConfiguration());
        //_ = modelBuilder.ApplyConfiguration(new RefreshTokenTypeConfiguration());
    }

    /// <summary>
    /// Enable sensitive data logging
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.EnableSensitiveDataLogging();
}
