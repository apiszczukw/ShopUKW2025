using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopUKW2025.Models.Users;

namespace ShopUKW2025.Controllers
{
    public class AccountController : Controller
    {
        UserManager<AppUser> _userManager;

        SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Register()
        {

            var user = await _userManager.FindByNameAsync("TestUser");

            if (user == null)
            {
                user = new AppUser()
                {
                    UserName = "TestUser",
                    Email = "testuser@ukw.edu.pl",
                    FirstName = "Jan",
                    LastName = "Kowalski"
                };

                var result = await _userManager.CreateAsync(user, "Test");
            }

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
