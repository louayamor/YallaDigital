using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YallaDigital.Models;

namespace YallaDigital.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Service> Services { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
    }
}