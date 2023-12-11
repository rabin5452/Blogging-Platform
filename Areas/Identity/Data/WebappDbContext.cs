using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Webapp.Areas.Identity.Data;
using Webapp.Models;

namespace Webapp.Data;

public class WebappDbContext : IdentityDbContext<WebappUser>
{
    public WebappDbContext(DbContextOptions<WebappDbContext> options)
        : base(options)
    {
    }
    public DbSet<WebappUser> webappUsers { get; set; }
    public DbSet<Post> posts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<WebappUser>
{
    public void Configure(EntityTypeBuilder<WebappUser> builder)
    {
        builder.Property(u => u.firstname).HasMaxLength(255);
        builder.Property(u => u.lastname).HasMaxLength(255);
    }

}
