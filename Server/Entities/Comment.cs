namespace Server.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? Content { get; set; }
        public int PostId { get; set; }
        public Post? Post { get; set; }

    }

}
