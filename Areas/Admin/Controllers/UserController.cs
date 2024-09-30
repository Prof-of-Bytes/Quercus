using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Quercus.Identity;


namespace Quercus.Admin
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private UserManager<User> userManager;
        private RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<User> um, RoleManager<IdentityRole> rm)
        {
            userManager = um;
            roleManager = rm;
        }

        public async Task<IActionResult> Dash()
        {
            List<QuercusUser> adminUsers = new List<QuercusUser>();

            foreach (User user in userManager.Users)
            {
                QuercusUser qu = (QuercusUser)user;
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