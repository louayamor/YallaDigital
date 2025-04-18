using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YallaDigital.Models;
using YallaDigital.DTO;

namespace YallaDigital.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    // GET: /Account/Register
    public IActionResult Register() => View();

    // POST: /Account/Register
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var user = new ApplicationUser
        {
            UserName = model.Email,
            Email = model.Email,
            FirstName = model.FirstName,
            LastName = model.LastName
        };

        var result = await _userManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
        {
            await _signInManager.SignInAsync(user, isPersistent: false);

            // ✅ Log authentication status
            Console.WriteLine($"[Register] User '{user.Email}' registered successfully.");
            Console.WriteLine($"[Register] IsAuthenticated: {User.Identity?.IsAuthenticated}");
            Console.WriteLine($"[Register] Authenticated User: {User.Identity?.Name}");

            return RedirectToAction("Index", "Home");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError("", error.Description);
        }

        return View(model);
    }

    // GET: /Account/Login
    public IActionResult Login() => View();

    // POST: /Account/Login
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var result = await _signInManager.PasswordSignInAsync(
            model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

        if (result.Succeeded)
        {
            // ✅ Log authentication status
            Console.WriteLine($"[Login] User '{model.Email}' logged in successfully.");
            Console.WriteLine($"[Login] IsAuthenticated: {User.Identity?.IsAuthenticated}");
            Console.WriteLine($"[Login] Authenticated User: {User.Identity?.Name}");

            return RedirectToAction("Index", "Home");
        }

        ModelState.AddModelError("", "Invalid login attempt.");
        return View(model);
    }

    // POST: /Account/Logout
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();

        Console.WriteLine("[Logout] User signed out.");
        return RedirectToAction("Index", "Home");
    }
}
