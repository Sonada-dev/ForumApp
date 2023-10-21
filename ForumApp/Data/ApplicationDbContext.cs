using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ForumApp.Models;
using Microsoft.AspNetCore.Identity;

namespace ForumApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppIdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ForumApp.Models.Forum> Forum { get; set; } = default!;
        public DbSet<ForumApp.Models.Topic> Topic { get; set; } = default!;
        public DbSet<ForumApp.Models.Comment> Comment { get; set; } = default!;
    }
}
