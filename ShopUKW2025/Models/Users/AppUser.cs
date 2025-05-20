using Microsoft.AspNetCore.Identity;

namespace ShopUKW2025.Models.Users
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
