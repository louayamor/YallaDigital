using Microsoft.EntityFrameworkCore;

namespace YallaDigital.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

}
