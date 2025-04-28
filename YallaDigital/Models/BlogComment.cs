namespace YallaDigital.Models

{
    public class BlogComment
    {
        public int Id { get; set; }
        
        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; } = null!; 
        
        public string AuthorName { get; set; } = null!; 
        public string Content { get; set; } = null!; 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
