using API.Models;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>

namespace API.General.Classes;

/// <summary>
/// Manage constants
/// </summary>
public class ProductConstants
{

    public const string Resources = "Resources";

    public const string enUS = "en-US";

    public const string esMX = "es-MX";

    public class UserConstants
    {


        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() {UserName= "XKRB", UserPassword="123", UserFirstName="Karla", UserLastName="Ramos Benitez"},
            new UserModel() {UserName="admin", UserPassword="123", UserFirstName="Karla", UserLastName="Ramos"}
        };
    }

    public class TableNames
    {
        public const string Users = " Users";
        public const string Products = "Products";
        public const string LogIns = "LogIns";
    }
}
