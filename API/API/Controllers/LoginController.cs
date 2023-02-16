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
public class LoginController :  BaseController
{
    /// <summary>
    /// Manage product busines logic
    /// </summary>
    private readonly ILogInService _loginService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="productService"></param>
    public LoginController(ILogInService loginService, IStringLocalizer<BaseController> localizer): base(localizer)
    {
        _loginService = loginService;   
    }

    


    //[HttpPost]
    //public IActionResult Login (LogInModel userLogin)
    //{
    //    var user = Authenticate(userLogin);

    //    if (user != null)
    //    {
    //        var token = GenerateToken(user);
    //        return Ok(token);
    //    }
    //    return NotFound("User Not found");
    //}

    [HttpPost]
    public async Task<IActionResult> AuthenticateUser (LogInModel userlogin)
    {
        try
        {
            //return Ok(await _loginService.AuthenticateUser(userlogin));

            var user = await _logInService.AuthenticateUser(userlogin);
            //UserModel user = await _logInService.AuthenticateUser(userlogin.UserName, userlogin.UserPassword);

            if (user != null)
            {
                //var token = await _logInService.GenerateToken();
                return Ok(/*token*/);
            }
            return NotFound("User Not found");
        }
        catch (APIException)
        {
            return BadRequest(new Request(7).GetActionResult());
        }
        catch(Exception e)
        {
            return BadRequest(e.Message);
        }
    }


    [HttpGet]
    public async Task<IActionResult> GenerateToken()
    {
        var token = await _loginService.GenerateToken();
        return Ok(token);
    }
    //private UserModel Authenticate(LogInModel userLogin)
    //{
    //    //método para Autenticar al usuario
    //    var currectUser = UserConstants.Users.FirstOrDefault(user => user.UserName.ToLower() == userLogin.UserName.ToLower() && user.UserPassword == userLogin.UserPassword);
    //    if (currectUser != null)
    //    {
    //        return currectUser;
    //    }
    //    return null;
    //}

    //private string GenerateToken(UserModel user)
    //{
    //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["jwt:key"]));
    //    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

    //    var claims = new[]
    //    {
    //        new Claim(ClaimTypes.NameIdentifier, user.UserName),
    //        new Claim(ClaimTypes.Email, user.UserEmail),
    //        new Claim(ClaimTypes.GivenName, user.UserFirstName),
    //        new Claim(ClaimTypes.Surname, user.UserLastName)
    //    };

    //    var tokem = new JwtSecurityToken(
    //        _config["Jwt:Issuer"],
    //        _config["Jwt:Audience"],
    //        claims,
    //        expires: DateTime.Now.AddMinutes(15),
    //        signingCredentials: credentials);

    //    return new JwtSecurityTokenHandler().WriteToken(tokem);
    //}
}
