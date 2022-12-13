using API.Repositories.Classes;
using API.Repositories.Interfaces;
using API.Services.Classes;
using API.Services.Interfaces;

namespace API.General.Classes.Configure;

/// <summary>
/// Dependency injection configuration
/// </summary>
public class DependencyInjectionConfigure
{
    /// <summary>
    /// Dependency injection configure service
    /// </summary>
    /// <param name="services">Service collection</param>

    public static void ConfigureService(IServiceCollection services)
    {
        _ = services.AddScoped<IProductService, ProductService>();
        _ = services.AddScoped<IProductRepository, ProductRepository>();
    }

    internal static void ConfigureService(object services) => throw new NotImplementedException();
}