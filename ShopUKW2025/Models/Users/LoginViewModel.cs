using System.ComponentModel.DataAnnotations;

namespace ShopUKW2025.Models.Users
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić login")]
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
