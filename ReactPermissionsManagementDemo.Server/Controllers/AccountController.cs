using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWebAppDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private UserManager<IdentityUser> _userManager;
    private SignInManager<IdentityUser> _signInManager;

    public AccountController(UserManager<IdentityUser> userManager,
                           SignInManager<IdentityUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet("IsAuthenticated")]
    public IActionResult IsAuthenticated()
    {
        if (User.Identity != null && User.Identity.IsAuthenticated)
        {
            return Ok(new { IsAuthenticated = true });
        }
        return Unauthorized(new { IsAuthenticated = false });
    }

}
