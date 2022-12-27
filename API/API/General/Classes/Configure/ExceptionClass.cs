namespace API.General.Classes.Configure;

public class ExceptionClass : Exception
{
    private string _message;

    public String Message { get { return _message; } }
    public ExceptionClass() { }

    public ExceptionClass(string message)
        : base(message)
    {
        _message = message;
    }
}
