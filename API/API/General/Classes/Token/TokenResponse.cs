using System.Data;

namespace API.General.Classes.Token;

public class TokenResponse
{
    /// <summary>
    /// Expire date
    /// </summary>
    public DateTime Expire { get; set; }

    /// <summary>
    /// Token
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// If the user has multiple roles
    /// </summary>
    public bool MultipleRoles { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool AllosSettingScreen { get; set; }

    /// <summary>
    /// Refresh token
    /// </summary>
    //    public RefreshToken RefreshToken { get; set; }

    //    /// <summary>
    //    /// UserRole
    //    /// </summary>
    //    public Roles Roles { get; set; }
}
