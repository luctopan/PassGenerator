using Microsoft.AspNetCore.Mvc;
using SecureIdentity.Password;

namespace PassGenerator.Controllers;

[ApiController]
public class PasswordController : ControllerBase
{
    [HttpGet("v1/password")]
    public IActionResult GetPassword([FromQuery] short size = 8)
    {
        var password = PasswordGenerator.Generate(size);
        return Ok(password);
    }
}