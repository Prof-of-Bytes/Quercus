using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;



namespace Quercus.Admin
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<IdentityUser> um, RoleManager<IdentityRole> rm)
        {
            userManager = um;
            roleManager = rm;
        }

        public async Task<IActionResult> Dash()
        {
            List<QuercusUser> adminUsers = new List<QuercusUser>();

            foreach (IdentityUser user in userManager.Users)
            {
                QuercusUser qu = (QuercusUser) user;
                qu.AssignedRoles = await userManager.GetRolesAsync(user);
                adminUsers.Add(qu);
            }
            AdminUserViewModel model = new AdminUserViewModel
            {
                Users = adminUsers,
                Roles = roleManager.Roles
            };
            return View(model);
        }
    }

}