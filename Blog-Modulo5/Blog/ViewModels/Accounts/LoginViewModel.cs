using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O email é obrigatorio")]
        [EmailAddress(ErrorMessage = "O email é invalido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatoria")]
        public string Password { get; set; }
    }
}
