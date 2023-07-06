using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace InternshipDemo;
public class DataSeeder : IDataSeeder
{
    private readonly TodoContext context;

    public DataSeeder(TodoContext context)
    {
        this.context = context;
    }

    public async Task SeedDataAsync()
    {
        var roleStore = new RoleStore<IdentityRole>(context);
        await roleStore.CreateAsync(new IdentityRole() { Name = Constants.UserRoles.Admin, NormalizedName = Constants.UserRoles.Admin.ToUpper() });
        await roleStore.CreateAsync(new IdentityRole() { Name = Constants.UserRoles.User, NormalizedName = Constants.UserRoles.User.ToUpper() });
        await context.SaveChangesAsync();
    }
}
