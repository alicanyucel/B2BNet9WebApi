using B2B.Business.Abstract;
using B2B.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace B2B.WebApi.Controllersaction;

[Route("api/[controller]/[action]")]
[ApiController]
public class AuthsController : ControllerBase
{
    private readonly IAuthService _authService;
    public AuthsController(IAuthService authService)
    {
        _authService = authService;
    }
    [HttpPost]
    public IActionResult Register(UserForRegister userForRegister)
    {
        var userExists = _authService.UserExists(userForRegister.Email);
        if (!userExists.Success)
        {
            return BadRequest(userExists.Message);
        }
        var registerResult = _authService.Register(userForRegister, userForRegister.Password);
        if (registerResult.Success)
        {
            return Ok(registerResult);
        }
        return BadRequest(registerResult.Message);
    }

}
