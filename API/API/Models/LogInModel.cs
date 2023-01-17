﻿namespace API.Models;

public class LogInModel
{
    /// <summary>
    /// Token
    /// </summary>
    public string _token;

    /// <summary>
    /// User´s id
    /// </summary>
    private readonly string _userId;

    /// <summary>
    /// token
    /// </summary>
    private readonly string _jwtId;

    /// <summary>
    /// verify if the user is logged
    /// </summary>
    private bool _loggedIn;

    /// <summary>
    /// DatiTime
    /// </summary>
    private readonly DateTime _dateTime;

    /// <summary>
    /// User´s id
    /// </summary>
    public string UserId => _userId;

    /// <summary>
    /// token
    /// </summary>
    public string JwtId => _jwtId;

    /// <summary>
    /// verify if the user is logged
    /// </summary>
    public bool LoggedIn { get => _loggedIn; set => _loggedIn = value; }

    /// <summary>
    /// Date time
    /// </summary>
    public DateTime DateTime => _dateTime;

    /// <summary>
    /// Token
    /// </summary>
    public string Token => _token;

    /// <summary>
    /// Constructor
    /// </summary>
    public LogInModel() { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="userId">users´s id</param>
    /// <param name="jwtId">session token</param>
    /// <param name="token">token</param>
    public LogInModel(string userId, string jwtId, string token)
    {
        _userId = userId;
        _jwtId = jwtId;
        _loggedIn = true;
        _dateTime = DateTime.UtcNow;
        _token = token;
    }
}
