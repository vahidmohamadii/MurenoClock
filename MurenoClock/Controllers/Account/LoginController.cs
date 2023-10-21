using BusinessLayer.Dtos.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MurenoClock.Controllers.Account;

public class LoginController : Controller
{
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly ILogger<LoginController> _logger;

    public LoginController(SignInManager<IdentityUser> signInManager, ILogger<LoginController> logger)
    {
        _signInManager= signInManager;
        _logger= logger;
    }
    [HttpGet]
    public async Task<IActionResult> Login()
    {
        //if (!string.IsNullOrEmpty(ErrorMessage))
        //{
        //    ModelState.AddModelError(string.Empty, ErrorMessage);
        //}
        //returnUrl ??= Url.Content("~/");

        // Clear the existing external cookie to ensure a clean login process
        await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

        //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

        //ReturnUrl = returnUrl;
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginDto login)
    {
        //returnUrl ??= Url.Content("~/");

        //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

        if (ModelState.IsValid)
        {
            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, set lockoutOnFailure: true
            var result = await _signInManager.PasswordSignInAsync(login.InputDto.Email, login.InputDto.Password, login.InputDto.RememberMe, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                _logger.LogInformation("User logged in.");
                //return LocalRedirect(returnUrl);
                return RedirectToAction("Index", "Home");
            }
            if (result.RequiresTwoFactor)
            {
                return RedirectToAction("Account","LoginWith2fa", new { /*ReturnUrl = returnUrl,*/ RememberMe = login.InputDto.RememberMe });
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning("User account locked out.");
                return RedirectToAction("Account","Lockout");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View();
            }
        }

        // If we got this far, something failed, redisplay form
        return View();
    }
}
