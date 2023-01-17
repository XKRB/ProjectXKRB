using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.VisualBasic;
using System.Globalization;

namespace API.General.Classes.Configure;

public class GlobalizationConfigure
{
    public static void ConfigureService(IServiceCollection services)
    {
        services.AddLocalization(options => { options.ResourcesPath = ProductConstants.Resources; });
        services.AddControllers();
        services.AddMvc(a => a.EnableEndpointRouting = false)
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
            DefaultRequestCulture = new RequestCulture(ProductConstants.enUS),
            // Formatting numbers, dates, etc.
            SupportedCultures = supportedCultures,
            // UI strings that we have localized.
            SupportedUICultures = supportedCultures,
        });//Globalization
    }
}
