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


        public async Task<IActionResult> Login()
        {
            var result = await _signInManager.PasswordSignInAsync("TestUser", "Test", false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.result = $"Nie udało się ({result})";
            }

            return View();
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
                ViewBag.result = "Zarejestrowano użytkownika\n" + result;
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
