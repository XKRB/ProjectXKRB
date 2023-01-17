// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
using API.Context.Context;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.General.Classes.Configure;

/// <summary>
/// Datebase Configure
/// </summary>
public class DatabaseConfigure
{
    public static void ConfigureService(IServiceCollection services, WebApplicationBuilder builder)
    {
        string? connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnection");
            //Configure our DBContext to our dependency injection system and configure to use postgres
            _ = services.AddDbContext<ProductContext>(options => options.UseNpgsql(connectionString));
        

        //string? connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnection");
        //builder.Services.AddDbContext<ProductContext>(options => options.UseNpgsql(connectionString));
    }
}
