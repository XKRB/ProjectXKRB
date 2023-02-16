using API.Context.Context;
using API.General.Classes;
using API.Models;
using API.Repositories.Interfaces;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories.Classes;
// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>

/// <summary>
/// Interface LogIn Repository
/// </summary>
public class LogInRepository /*: ILogInRepository*/
{
    ///// <summary>
    ///// To query logs tables
    ///// </summary>
    //private readonly LogInContext _logInContext;

    ///// <summary>
    ///// Parameters are passed via dependency injection to query tables
    ///// </summary>
    //public LogInRepository(LogInContext logInContext) => _logInContext = logInContext;

    ///// <summary>
    ///// Verify if the USerName exist
    ///// </summary>
    ///// <param name="userName"> UserName </param>
    ///// <returns></returns>
    //public async Task<bool> AuthenticateUser(string userName, string userPassword) => await _logInContext.LogIns.AnyAsync(user => user.UserName.ToLower() == userName.ToLower() && user.UserPassword == userPassword);

    ///// <summary>
    ///// Register new User Login
    ///// </summary>
    ///// <param name="userLogin">UserName and Password </param>
    ///// <returns></returns>
    //public async Task LoginUser(LogInModel userLogin)
    //{
    //    await _logInContext.LogIns.AddAsync(userLogin);
    //    await _logInContext.SaveChangesAsync();

    //}


    ///// <summary>
    ///// To register new login
    ///// </summary>
    ///// <param name="userId">User´s Id</param>
    ///// <param name="Jti">Token id</param>
    ///// <param name="token">Token</param>
    ///// <returns>Task</returns>
    //public async Task RegisterLogIn(string userId, string Jti, string token)
    //{
    //    LogInModel LogInEntity = new LogInModel(userId, Jti, token);

    //    _ = await _logInContext.AddAsync(LogInEntity);
    //    _ = await _logInContext.SaveChangesAsync();
    //}
}
