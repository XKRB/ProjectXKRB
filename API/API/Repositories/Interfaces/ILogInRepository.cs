// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Repositories.Interfaces;

/// <summary>
/// LogIn Repository
/// </summary>
public interface ILogInRepository
{
    /// <summary>
    /// Verify if the USerName exist
    /// </summary>
    /// <param name="userName"></param>
    /// <returns></returns>
    Task<ActionResult<LogInModel>> AuthenticateUser(LogInModel userlogin);

    //    /// <summary>
    //    /// Register new User Login
    //    /// </summary>
    //    /// <param name="userLogin"></param>
    //    /// <returns></returns>
    //    Task LoginUser(LogInModel userLogin);
}
