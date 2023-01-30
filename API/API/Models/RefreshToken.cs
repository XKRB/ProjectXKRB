namespace API.Models;

public class RefreshToken
{
    /// <summary>
    /// Refreshed token
    /// </summary>
    private readonly string _token;

    /// <summary>
    /// JwtId last token
    /// </summary>
    private readonly string _jwtId;

    /// <summary>
    /// Creation date
    /// </summary>
    private readonly DateTime _creationDate;

    /// <summary>
    /// Expirate date
    /// </summary>
    private readonly DateTime _expiryDate;

    /// <summary>
    /// Token status
    /// </summary>
    private short _idStatus;

    /// <summary>
    /// User Id
    /// </summary>
    private readonly string _userId;

    /// <summary>
    /// Refreshed token
    /// </summary>
    public string Token => _token;

    /// <summary>
    /// JwtId last token
    /// </summary>
    public string JwtId => _jwtId;

    /// <summary>
    /// Creation date
    /// </summary>
    public DateTime CreationDate => _creationDate;

    /// <summary>
    /// Expirate date
    /// </summary>
    public DateTime ExpiryDate => TimeZoneInfo.ConvertTimeToUtc(_expiryDate);

    /// <summary>
    /// User Id
    /// </summary>
    public string UserId => _userId;

    /// <summary>
    /// Constructor
    /// </summary>
    public RefreshToken() { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="token">Refreshed token</param>
    /// <param name="jwtId">JWTID</param>
    /// <param name="expiry">Expiry</param>
    /// <param name="userId">User´s id</param>
    public RefreshToken(string token, string jwtId, DateTime expiry, string userId)
    {
        _token = token;
        _jwtId = jwtId;
        _creationDate = DateTime.UtcNow;
        _expiryDate = expiry;
        //_idStatus = (short)TokenStatusEnum.Available;
        _userId = userId;
    }
}
