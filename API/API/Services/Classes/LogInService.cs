using API.Context.Context;
using API.General.Classes;
using API.Models;
using API.Repositories.Classes;
using API.Repositories.Interfaces;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

    /// <summary>
    /// Parameters are passed via dependency injection to query tables
    /// </summary>
    public LogInService(ILogInRepository logInRepository) => _logInRepository = logInRepository;

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

    //public async Task LogInUser(LogInModel userlogin) => await _logInRepository.AuthenticateUser(userName, userPassword)
    //    ? throw new APIException(2)
    //    : await _logInRepository.AuthenticateUser(product);


    //if (!await _logInRepository.AuthenticateUser(userLogin))
    //{
    //    throw new APIException(8);
    //}
    //else
    //{
    //    throw new APIException(6);
    //}
}
