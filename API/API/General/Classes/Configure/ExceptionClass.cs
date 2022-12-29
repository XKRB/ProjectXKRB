namespace API.General.Classes.Configure;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
public class ExceptionClass : Exception
{
    /// <summary>
    /// Message Id
    /// </summary>
    private readonly string _message;

    /// <summary>
    /// Message Id
    /// </summary>
    public string Message => _message;

    /// <summary>
    /// Constructor
    /// </summary>
    public ExceptionClass() { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="message"></param>
    public ExceptionClass(string message)
        : base(message) => _message = message;
}
