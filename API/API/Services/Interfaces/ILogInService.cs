using API.Models;

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
    Task LoginUser(LogInModel userLogin);

}
