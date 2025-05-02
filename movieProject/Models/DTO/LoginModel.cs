using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;

namespace MovieProject.Models.DTO
{
    public class LoginModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? Password { get; set; }

    }
}
