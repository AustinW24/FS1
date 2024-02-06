namespace Server.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
