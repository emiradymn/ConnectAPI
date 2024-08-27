using Microsoft.AspNetCore.Identity;

namespace ConnectAPI.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string FullName { get; set; } = null!;

        public DateTime DateAdded { get; set; }
    }
}