using API.Controllers;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.General.Classes;

/// <summary>
/// Request
/// </summary>
public class Request
{
    /// <summary>
    /// Message ID
    /// </summary>
    private int _idMessage;

    /// <summary>
    /// Message
    /// </summary>
    private string _message;

    /// <summary>
    /// Message ID
    /// </summary>
    public int IdMessage { get => _idMessage; set => _idMessage = value; }

    /// <summary>
    /// Message
    /// </summary>
    public string Message { get => _message; set => _message = value; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="idMessage"> Message Id to translate</param>
    public Request(int idMessage) => _idMessage = idMessage;

    /// <summary>
    /// Get the action result
    /// </summary>
    /// <returns></returns>
    public Request GetActionResult()
    {
        _message = BaseController._globalLocalizer[_idMessage.ToString()];
        return this;
    }
}
