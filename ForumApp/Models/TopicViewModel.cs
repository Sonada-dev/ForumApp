namespace ForumApp.Models
{
    public class TopicViewModel
    {
        public required Topic Topic { get; set; }
        public Comment? Comment { get; set; }
    }
}
