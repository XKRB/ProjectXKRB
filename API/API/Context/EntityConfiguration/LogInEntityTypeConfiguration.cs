using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Context.EntityConfiguration;

public class LogInEntityTypeConfiguration : IEntityTypeConfiguration<LogInModel>
{
    /// <summary>
    /// Configures properties of a LogIn entity
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<LogInModel> builder)
    {
        _ = builder.HasKey(key => new { key.UserId, key.JwtId });

        //Configure the properties
        _ = builder.Property(property => property.LoggedIn);
        _ = builder.Property(property => property.DateTime);
        _ = builder.Property(property => property.Token);
    }
}
