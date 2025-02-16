using Microsoft.AspNetCore.Identity;

namespace userAuthentication_module.model
{
    public class Users : IdentityUser
    {
        public string fullName {get; set;} = string.Empty;
    }
}