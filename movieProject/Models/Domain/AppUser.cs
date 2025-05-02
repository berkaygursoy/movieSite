using Microsoft.AspNetCore.Identity;

namespace MovieProject.Models.Domain
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
