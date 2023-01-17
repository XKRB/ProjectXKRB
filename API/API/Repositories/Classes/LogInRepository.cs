using API.Repositories.Interfaces;

namespace API.Repositories.Classes;

public class LogInRepository : ILogInRepository
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

    ///// <summary>
    ///// Release database allocate resources
    ///// </summary>
    ///// <returns>Task</returns>
    //public async Task Dispose() => await _logInContext.DisposeAsync();
}
