using Microsoft.AspNetCore.Identity;

namespace ForumApp.Models
{
    public class AppIdentityUser : IdentityUser
    {
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Topic>? Topics { get; set; }
    }
}
