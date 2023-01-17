using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Controllers;

/// <summary>
/// Base Controller 
/// </summary>
public class BaseController : Controller
{

    /// <summary>
    /// Globalization to change language
    /// </summary>
    protected IStringLocalizer<BaseController> _localizer;

    /// <summary>
    /// Globalization to change language
    /// </summary>
    public static IStringLocalizer<BaseController> _globalLocalizer;

    /// <summary>
    /// To log the session data
    /// </summary>
    protected ILogInService _logInService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="localizer">Localizer</param>
    /// <param name="logInService">LogInservice</param>
    public BaseController(IStringLocalizer<BaseController> localizer)
    {
        _globalLocalizer = localizer;
        _localizer = localizer;
        //_logInService = logInService;
    }
}
