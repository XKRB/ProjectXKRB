using Azure.Core;
using System.Net;

namespace API.General.Classes;

public class APIException : ApplicationException
{
    /// <summary>
    /// Message id
    /// </summary>
    private readonly int _idMessage;

    /// <summary>
    /// To now which status code return
    /// </summary>
    private readonly HttpStatusCode _statusCode;

    /// <summary>
    /// Request error
    /// </summary>
    private readonly Request _requestError;

    /// <summary>
    /// Create a API exception
    /// </summary>
    /// <param name="idMessage">message´s id</param>
    /// <param name="message">Message that describes the exception</param>
    /// <param name="statusCode">status code</param>
    /// <param name="originalException">Exception that originated the controlled exception (default null)</param>
    /// <param name="logLevel">Determines in what category should the log classify it</param>
    /// <param name="extraInfo">Extra information for this particular exception</param>
    public APIException(int idMessage, string message) => _idMessage = idMessage;

}
