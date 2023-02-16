using API.Context.Context;
using API.General.Classes;
using API.Models;
using API.Repositories.Classes;
using API.Repositories.Interfaces;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Services.Classes;

/// <summary>
/// LogIn Service
/// </summary>
public class LogInService : ILogInService
{
    /// <summary>
    /// To manage data from the logIn table
    /// </summary>
    private readonly ILogInRepository _logInRepository;

    private readonly IConfiguration _config;

    /// <summary>
    /// Parameters are passed via dependency injection to query tables
    /// </summary>
    public LogInService(ILogInRepository logInRepository, IConfiguration config) => _logInRepository = logInRepository;


    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param name="userLogin"></param>
    ///// <returns></returns>
    ///// 
    ////public async Task LoginUser(LogInModel userLogin)
    ////{
    ////    if ( await _logInRepository.AuthenticateUser(userLogin.UserName, userLogin.UserPassword) == false)
    ////    {
    ////        throw new APIException(7);
    ////    }
    ////    else
    ////    {
    ////        await _logInRepository.LoginUser(userLogin);
    ////    }
    ////}
    //public async Task LoginUser(LogInModel userLogin)
    //{
    //    await _logInRepository.LoginUser(userLogin);
    //}

    public async Task<ActionResult<LogInModel>> AuthenticateUser(LogInModel userlogin)
    {
        return await _logInRepository.AuthenticateUser(userlogin);
        //if ( await _logInRepository.AuthenticateUser(userlogin))
        //{
        //    throw new APIException(8);
        //}
        //else
        //{
        //    return await _logInRepository.AuthenticateUser(userlogin);
        //}
        
    }
    public async Task<string> GenerateToken(/*LogInModel user*/)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["jwt:key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        //var claims = new[]
        //{
        //    new Claim(ClaimTypes.NameIdentifier, user.UserName),
        //    //new Claim(ClaimTypes.Email, user.UserEmail),
        //    //new Claim(ClaimTypes.GivenName, user.UserFirstName),
        //    //new Claim(ClaimTypes.Surname, user.UserLastName)
        //};

        var tokem = new JwtSecurityToken(
            _config["Jwt:Issuer"],
            _config["Jwt:Audience"],
            //claims,
            expires: DateTime.Now.AddMinutes(15),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(tokem);
    }
}
