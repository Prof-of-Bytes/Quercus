using Microsoft.AspNetCore.Identity;

using Quercus.Admin;

public class AdminUserViewModel{

    public IEnumerable<QuercusUser> Users {get; set;} = null!;

    public IEnumerable<IdentityRole> Roles {get; set; } = null!;
}