using API.Services.Interfaces;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Services.Classes;

/// <summary>
/// LogIn Service
/// </summary>
public class LogInService : ILogInService
{
    ///// <summary>
    ///// To manage data from the logIn table
    ///// </summary>
    //public ILogInRepository _logInRepository;

    ///// <summary>
    ///// Token manager
    ///// </summary>
    //private readonly ITokenManager _tokenGenerator;

    ///// <summary>
    ///// To manage data from User table
    ///// </summary>
    //private readonly IProductService _productService;

    ///// <summary>
    ///// Parameters are passed via dependency injection to manage tables data
    ///// </summary>
    //public LogInService(ILogInRepository logInRepository, ITokenManager tokenGenerator, IProductService productService)
    //{
    //    _logInRepository = logInRepository;
    //    _tokenGenerator = tokenGenerator;
    //    _productService = productService;
    //}

    ///// <summary>
    ///// To register new login
    ///// </summary>
    ///// <param name="userId">User´s Id</param>
    ///// <param name="token">Token</param>
    ///// <returns>Task</returns>
    //public async Task RegisterLogIn(string userId, string token)
    //{
    //    ClaimsPrincipal claims = _tokenGenerator.ReadToken(token);

    //    if (claims == null)
    //    {
    //        throw new ExceptionClass(6);
    //    }

    //    string jti = claims.Claims.Single(x => x.Type == JwtRegisteredClaimNames.Jti).Value;

    //    await _logInRepository.RegisterLogIn(userId, jti, token);
    //}

    ///// <summary>
    ///// Release database allocate resources
    ///// </summary>
    ///// <returns>Task</returns>
    //public async Task Dispose() => await _logInRepository.Dispose();
}
