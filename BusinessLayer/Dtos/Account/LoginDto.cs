

using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Dtos.Account;

public class LoginDto
{
    public InputDto InputDto { get; set; }

}
public class InputDto
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
