using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumApp.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public required string Content { get; set; }

        public required int Topic_Id { get; set; }

        [ForeignKey(nameof(Topic_Id))]
        public Topic? Topic { get; set; }

        public required string Created_By { get; set; }

        [ForeignKey(nameof(Created_By))]
        public AppIdentityUser? User { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Created_At { get; set; }

        
        public int? Parent_Comment_Id { get; set; } = null;

        [ForeignKey(nameof(Parent_Comment_Id))]
        public Comment? ParentComment { get; set; }

        public ICollection<Comment>? ChildComments { get; set; }
    }
}
