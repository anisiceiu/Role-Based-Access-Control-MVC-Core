using Microsoft.AspNetCore.Identity;

namespace RBACWebApplicationMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add custom properties here if you want
        public string FullName { get; set; }
    }
}
