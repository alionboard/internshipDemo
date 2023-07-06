using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternshipDemo;
public class TodoContext : IdentityDbContext<IdentityUser>
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {

    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>()
        .HasData(
            new IdentityRole() { Id = "0", Name = Constants.UserRoles.Admin, NormalizedName = Constants.UserRoles.Admin.ToUpper() },
            new IdentityRole() { Id = "1", Name = Constants.UserRoles.User, NormalizedName = Constants.UserRoles.User.ToUpper() }
        );
    }
}
