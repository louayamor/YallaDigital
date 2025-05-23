namespace YallaDigital.Models;

public class Service
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; } = 0;
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}
