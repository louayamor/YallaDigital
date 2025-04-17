// Models/ApplicationUser.cs
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace YallaDigital.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(500)]
        public string? ProfilePictureUrl { get; set; }

        public string? CompanyName { get; set; }
        public string? Industry { get; set; }

        public bool IsAdmin { get; set; } = false;
        public DateTime? LastLoginDate { get; set; }
    }
}