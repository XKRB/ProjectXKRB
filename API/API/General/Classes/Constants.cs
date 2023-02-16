using API.Models;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>

namespace API.General.Classes;

/// <summary>
/// Manage constants
/// </summary>
public class Constants
{

    public const string Resources = "Resources";

    public const string enUS = "en-US";

    public const string esMX = "es-MX";

    public class UserConstants
    {


        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() {UserName = "XKRB", UserPassword = "123", UserEmail = "karla@gmail.com", UserFirstName = "Karla", UserLastName = "Ramos Benitez"},
            new UserModel() {UserName = "admin", UserPassword = "123", UserEmail = "Ramos@gmail.com", UserFirstName = "Karla", UserLastName = "Ramos Venegas"}
        };
    }

    public class TableNames
    {
        public const string Users = " Users";
        public const string Products = "Products";
        public const string LogIns = "LogIns";
    }
}
