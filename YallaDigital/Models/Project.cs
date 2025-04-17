namespace YallaDigital.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string? ClientTestimonial { get; set; }

    public int? ServiceId { get; set; }
    public Service? Service { get; set; }
}
