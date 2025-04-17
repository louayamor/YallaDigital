namespace YallaDigital.DTO;

using System.ComponentModel.DataAnnotations;

public class RegisterModel
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required, MinLength(6)]
    public string Password { get; set; }
    
    public string? CompanyName { get; set; }
    public string? Industry { get; set; }

    public string Role { get; set; }
}