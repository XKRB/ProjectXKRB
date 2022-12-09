using Azure.Core;
using Microsoft.Extensions.Logging;
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
    //private readonly HttpStatusCode _statusCode;

    /// <summary>
    /// Request error
    /// </summary>
    private readonly Request _requestError;

    /// <summary>
    /// Contains the values of status code defined for HTTP
    /// </summary>
    //public HttpStatusCode StatusCode
    //{
    //    get => _statusCode; set
    //    {
    //        _statusCode = value;
    //    }
    //}

    /// <summary>
    /// Request error info
    /// </summary>
    public Request RequestError => _requestError;

    /// <summary>
    /// Message id
    /// </summary>
    public int IdMessage => _idMessage;

    /// <summary>
    /// Create a API exception
    /// </summary>
    /// <param name="idMessage">message´s id</param>
    /// <param name="message">Message that describes the exception</param>
    /// <param name="statusCode">status code</param>
    /// <param name="originalException">Exception that originated the controlled exception (default null)</param>
    /// <param name="logLevel">Determines in what category should the log classify it</param>
    /// <param name="extraInfo">Extra information for this particular exception</param>
    public APIException(int idMessage, string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest, Exception originalException = null, params string[] extraInfo)
    {
        _idMessage = idMessage;
        //_statusCode = statusCode;
        _requestError = new Request { IdMessage = idMessage, Message = message };

        Log(message, originalException, logLevel, extraInfo);
    }
}
