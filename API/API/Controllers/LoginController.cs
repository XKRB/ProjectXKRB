using API.General.Classes;
using API.Models;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static API.General.Classes.Constants;
using static API.General.Classes.Constants.UserConstants;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Controllers;

/// <summary>
/// Login Controller
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase /*: BaseController*/
{
    private readonly IConfiguration _config;
    public LoginController(IConfiguration config)
    {
        _config = config;
    }

    //private readonly ILogInService _logInService;
    //public LoginController(ILogInService logInService, IStringLocalizer<BaseController> localizer): base(localizer) => _logInService = logInService;

    [HttpPost]
    public IActionResult Login (LogInModel userLogin)
    {
        var user = Authenticate(userLogin);

        if (user != null)
        {
            var token = GenerateToken(user);
            return Ok(token);
        }
        return NotFound("User Not found");
    }

    private UserModel Authenticate(LogInModel userLogin)
    {
        var currectUser = UserConstants.Users.FirstOrDefault(user => user.UserName.ToLower() == userLogin.UserName.ToLower() && user.UserPassword == userLogin.UserPassword);
        if (currectUser != null)
        {
            return currectUser;
        }
        return null;
    }

    private string GenerateToken(UserModel user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["jwt:key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.UserName),
            new Claim(ClaimTypes.Email, user.UserEmail),
            new Claim(ClaimTypes.GivenName, user.UserFirstName),
            new Claim(ClaimTypes.Surname, user.UserLastName)
        };

        var tokem = new JwtSecurityToken(
            _config["Jwt:Issuer"],
            _config["Jwt:Audience"],
            claims,
            expires: DateTime.Now.AddMinutes(15),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(tokem);
    }
    //public async Task<ActionResult> LoginUser(LogInModel userLogin)
    //{
    //    try
    //    {
    //        await _logInService.LoginUser(userLogin);
    //        return Ok(new Request(6).GetActionResult());
    //    }
    //    catch(APIException)
    //    {
    //        //return BadRequest(new Request(7).GetActionResult());
    //        return NotFound(new Request(7).GetActionResult());

    //    }
    //    catch (Exception e)
    //    {
    //        return BadRequest(e.Message);
    //    }
    //}
}
