using API.Services.Classes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/// <summary>
/// Token Controller
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class TokenController: ControllerBase
{
    private readonly TokenService _token;

    public TokenController(TokenService token)
    {
        _token= token;
    }

    [HttpPost]
    public string GenerateToken()
    {
        return _token.GenerateToken();
    }
}
