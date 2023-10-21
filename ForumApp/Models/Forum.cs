using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumApp.Models
{
    public class Forum
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        public int? Parent_Forum_Id { get; set; } = null;

        [ForeignKey(nameof(Parent_Forum_Id))]
        public Forum? ParentForum { get; set; }
        public ICollection<Forum>? ChildForums { get; set; }
        public ICollection<Topic>? Topics { get; set; }
    }
}
