namespace YallaDigital.Models;

public class Testimonial
{
    public int Id { get; set; }
    public string ClientName { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string? ClientPhotoUrl { get; set; }
}
