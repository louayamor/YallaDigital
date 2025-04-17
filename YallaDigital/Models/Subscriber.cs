namespace YallaDigital.Models;

public class Subscriber
{
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public DateTime SubscribedAt { get; set; } = DateTime.UtcNow;
}
