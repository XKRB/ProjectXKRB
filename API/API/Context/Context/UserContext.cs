using API.Context.EntityConfiguration;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context.Context;

public class UserContext:DbContext
{
    /// <summary>
    /// To query Products table
    /// </summary>
    public DbSet<LogInModel> Users { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public UserContext(DbContextOptions<UserContext> options) : base(options)
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
