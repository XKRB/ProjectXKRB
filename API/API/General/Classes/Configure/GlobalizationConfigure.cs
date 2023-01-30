using API.Controllers;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using System.Resources;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.General.Classes.Configure;

/// <summary>
/// Globalization configure
/// </summary>
public class GlobalizationConfigure
{
    /// <summary>
    /// Globalization configure
    /// </summary>
    /// <param name="services"></param>
    public static void ConfigureService(IServiceCollection services)
    {
        _ = services.AddLocalization(options => { options.ResourcesPath = ProductConstants.Resources; });
        _ = services.AddControllers();
        _ = services.AddMvc(a => a.EnableEndpointRouting = false)
            .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            .AddDataAnnotationsLocalization();

        //Globalization
        _ = services.Configure<RequestLocalizationOptions>(opts =>
           {
               List<CultureInfo> supportedCultures = new List<CultureInfo>
               {
                    new CultureInfo(ProductConstants.enUS),
                    new CultureInfo(ProductConstants.esMX),
               };
               opts.DefaultRequestCulture = new RequestCulture(ProductConstants.enUS);
               //Formating numbers, dates, etc.
               opts.SupportedCultures = supportedCultures;
               //UI strings that we have localazed
               opts.SupportedUICultures = supportedCultures;
           }); //Globalization
    }

    /// <summary>
    /// Configure
    /// </summary>
    /// <param name="app"></param>
    public static void Configure(IApplicationBuilder app)
    {
        //Globalization
        CultureInfo[] supportedCultures = new[]
        {
                new CultureInfo(ProductConstants.enUS),
                new CultureInfo(ProductConstants.esMX),
            };

        _ = app.UseRequestLocalization(new RequestLocalizationOptions
        {
            DefaultRequestCulture = new RequestCulture(ProductConstants.esMX),
            // Formatting numbers, dates, etc.
            SupportedCultures = supportedCultures,
            // UI strings that we have localized.
            SupportedUICultures = supportedCultures,
        });//Globalization
    }
}
