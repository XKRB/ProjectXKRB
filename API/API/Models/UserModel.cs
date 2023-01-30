// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Models;

/// <summary>
/// User Model
/// </summary>
public class UserModel
{
        /// <summary>
    /// UserName
    /// </summary>
    private string _userName;

    /// <summary>
    /// User Password
    /// </summary>
    private string _userPassword;

    /// <summary>
    /// User FirstName
    /// </summary>
    private string _userFirstName;

    /// <summary>
    /// User LasName
    /// </summary>
    private string _userLastName;

    /// <summary>
    /// UserName
    /// </summary>
    public string UserName { get => _userName;set => _userName = value; }

    /// <summary>
    /// User Password
    /// </summary>
    public string UserPassword { get => _userPassword;set => _userPassword = value; }

    /// <summary>
    /// User FirstName
    /// </summary>
    public string UserFirstName { get => _userFirstName; set => _userFirstName = value; }


    /// <summary>
    /// User LasName
    /// </summary>
    public string UserLastName { get => _userLastName; set => _userLastName = value; }

    /// <summary>
    /// Constructor vacio
    /// </summary>
    public UserModel() { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="IdUSer"></param>
    /// <param name="UserName"></param>
    /// <param name="Password"></param>
    public UserModel(string userName, string userPassword, string userFirstName, string userLastName )
    {
        _userName = userName;
        _userPassword= userPassword;
        _userFirstName = userFirstName;
        _userLastName = userLastName;
    }
}
