using System.ComponentModel.DataAnnotations;

namespace ShopUKW2025.Models.Users
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić email")]
        [EmailAddress(ErrorMessage = "Niepoprawny format email")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hasła muszą być jednakowe")]
        public string ConfirmPassword { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
