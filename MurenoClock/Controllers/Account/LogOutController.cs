using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MurenoClock.Controllers.Account;

public class LogOutController : Controller
{
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly ILogger<LogOutController> _logger;

    public LogOutController(SignInManager<IdentityUser> signInManager, ILogger<LogOutController> logger)
    {
        _signInManager = signInManager;
        _logger = logger;
    }
    [HttpPost]
    public async Task<IActionResult> LogOut(/*string returnUrl = null*/)
    {
        await _signInManager.SignOutAsync();
        _logger.LogInformation("User logged out.");
        //if (returnUrl != null)
        //{
        //    return LocalRedirect(returnUrl);
        //}
        //else
        //{
            // This needs to be a redirect so that the browser performs a new
            // request and the identity for the user gets updated.
            return RedirectToAction("Home","Index");
        //}
    }

}
