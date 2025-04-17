using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using YallaDigital.Models;

namespace YallaDigital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin")] 
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = _userManager.Users.Select(user => new
            {
                user.Id,
                user.Email,
                user.FirstName,
                user.LastName,
                user.CompanyName,
                user.Industry
            }).ToList();

            return Ok(users);
        }

    }
}
