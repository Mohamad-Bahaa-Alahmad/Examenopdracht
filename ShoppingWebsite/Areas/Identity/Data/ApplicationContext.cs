using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingWebsite.Areas.Identity.Data;
using ShoppingWebsite.Models;

namespace ShoppingWebsite.Data;

public class ApplicationContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }
    public DbSet<ShoppingWebsite.Models.Messages> Messages { get; set; }

    public DbSet<ShoppingWebsite.Models.Order> Order { get; set; }

    public DbSet<ShoppingWebsite.Models.Product> Product { get; set; }

    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    
    public DbSet<ShoppingWebsite.Models.Language> Language { get; set; }

    
   

    





}
