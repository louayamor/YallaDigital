namespace YallaDigital.Models;

public class TeamMember
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string Role { get; set; } = null!;
    public string Bio { get; set; } = null!;
    public string PhotoUrl { get; set; } = null!;
}
