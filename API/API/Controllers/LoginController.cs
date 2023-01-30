using API.General.Classes;
using API.Models;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Controllers;

/// <summary>
/// Login Controller
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class LoginController : BaseController
{
    private readonly ILogInService _logInService;
    public LoginController(ILogInService logInService, IStringLocalizer<BaseController> localizer): base(localizer) => _logInService = logInService;

    [HttpPost/*("{userName}, {password}")*/]
    public async Task<ActionResult> LoginUser(LogInModel userLogin)
    {
        try
        {
            await _logInService.LoginUser(userLogin);
            return Ok(new Request(6).GetActionResult());
        }
        catch(APIException)
        {
            //return BadRequest(new Request(7).GetActionResult());
            return NotFound(new Request(7).GetActionResult());

        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
