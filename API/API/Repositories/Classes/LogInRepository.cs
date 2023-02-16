using API.Context.Context;
using API.General.Classes;
using API.Models;
using API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using static API.General.Classes.Constants;

namespace API.Repositories.Classes;
// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>

/// <summary>
/// Interface LogIn Repository
/// </summary>
public class LogInRepository : ILogInRepository
{
    /// <summary>
    /// To query logs tables
    /// </summary>
    private readonly LogInContext _logInContext;

    /// <summary>
    /// Parameters are passed via dependency injection to query tables
    /// </summary>
    public LogInRepository(LogInContext logInContext) => _logInContext = logInContext;

    public async Task<ActionResult<LogInModel>> AuthenticateUser(LogInModel userlogin)
    {
        LogInModel log = await _logInContext.LogIns.FirstOrDefaultAsync(user => user.UserName.ToLower() == userlogin.UserName.ToLower() && user.UserPassword == userlogin.UserPassword);
        if (!await _logInContext.LogIns.AnyAsync(user => user.UserName == userlogin.UserName && user.UserPassword == userlogin.UserPassword))
        {
            throw new APIException(7);
        }
        else
        {
            return log;
        }
        //public async Task AuthenticateUser(LogInModel userlogin) => await _logInContext.LogIns.AnyAsync(user => user.UserName.ToLower() == userName.ToLower() && user.UserPassword == userPassword);
        
        
        
        //LogInModel log = new await _logInContext.LogIns.FirstOrDefaultAsync(user => user.UserName == userlogin.UserName);
        ////var DBcheck = UserConstants.Users.FirstOrDefault(user => user.UserName.ToLower() == userlogin.UserName.ToLower() && user.UserPassword == userlogin.UserPassword);
        //if (log != null)
        //{
        //    return ;
        //}
        //else
        //{
        //    return null;
        //}


        //if (await _logInContext.LogIns.FirstOrDefaultAsync(user => user.UserName == userlogin.UserName))
        //{
        //    throw new APIException(7);
        //}
        //else
        //{
        //    return Ok;
        //}
        //return await _logInContext.LogIns.FirstOrDefault(user => user.UserName == userlogin.UserName && user.UserPassword == userlogin.UserPassword);
    }
}
