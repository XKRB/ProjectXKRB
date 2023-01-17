// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.General.Classes;

public class LogInformation
{
    public string Name { get; }

    public string Description { get; }

    public string[] Information { get; }

    public LogInformation(string name, string description, string[] information)
    {
        Name = name;
        Description = description;
        Information = information;
    }
}
