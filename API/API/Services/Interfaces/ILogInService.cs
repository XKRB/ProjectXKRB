using API.Models;
using Microsoft.AspNetCore.Mvc;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Services.Interfaces;

/// <summary>
/// LogIn service
/// </summary>
public interface ILogInService
{
    /// <summary>
    ///  User Login
    /// </summary>
    /// <param name="userLogin"> Username and password </param>
    /// <returns> task </returns>
    Task<ActionResult<LogInModel>> AuthenticateUser(LogInModel userlogin);

    /// <summary>
    ///  Generate Token
    /// </summary>
    /// <param name="userLogin"> Username and password </param>
    /// <returns> task </returns>
    Task<string> GenerateToken();
}
