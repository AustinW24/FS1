namespace Server.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }

}
