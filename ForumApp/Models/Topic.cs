using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumApp.Models
{
    public class Topic
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public int Forum_Id { get; set; }

        [ForeignKey(nameof(Forum_Id))]
        public Forum? Forum { get; set; }


        [Required]
        public required string Created_By { get; set; }

        [ForeignKey(nameof(Created_By))]
        public AppIdentityUser? AppIdentityUser { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
