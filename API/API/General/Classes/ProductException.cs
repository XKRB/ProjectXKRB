using API.Controllers;
using System.Net;

namespace API.General.Classes;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
public class ProductException : Exception
{
    /// <summary>
    /// Message Id
    /// </summary>
    private readonly int _idMessage;

    /// <summary>
    /// Request error
    /// </summary>
    private readonly Request _requestError;

    /// <summary>
    /// To now which status code return
    /// </summary>
    private HttpStatusCode _statusCode;

    /// <summary>
    /// Message Id
    /// </summary>
    public int IdMessage => _idMessage;

    /// <summary>
    /// Request error info
    /// </summary>
    public Request RequestError => _requestError;

    /// <summary>
    /// Contains the values of status code defined for HTTP
    /// </summary>
    public HttpStatusCode StatusCode { get => _statusCode; set => _statusCode = value; }

    /// <summary>
    /// Constructor
    /// </summary>
    public ProductException() { }

    public ProductException(int idMessage, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
    {
        _idMessage = idMessage;
        _statusCode = statusCode;
        _requestError = new Request(idMessage);
        _ = BaseController._globalLocalizer[_requestError.IdMessage.ToString()];

    }

    //public ActionResult GetActionResult()
    //{
    //    RequestError.Message = BaseController._globalLocalizer[_requestError.IdMessage.ToString()];
    //    return new ProductResult(StatusCode, RequestError);
    //}
}
