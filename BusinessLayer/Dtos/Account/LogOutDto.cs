

using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Dtos.Account;

public class LogOutDto
{

    public LogOutInputDto LogOutInputDto { get; set; }

    //public IList<AuthenticationScheme> ExternalLogins { get; set; }

    //public string ReturnUrl { get; set; }

}
public class LogOutInputDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Remember me?")]
    public bool RememberMe { get; set; }
}