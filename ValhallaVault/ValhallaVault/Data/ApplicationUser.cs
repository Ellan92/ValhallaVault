using Microsoft.AspNetCore.Identity;
using ValhallaVault.Models;

namespace ValhallaVault.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<ResponseModel> Responses { get; set; } = new();
    }

}
