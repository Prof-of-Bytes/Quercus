using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;
using Quercus.Repos;
using Quercus.Models;
using System.Security.Cryptography.X509Certificates;



namespace Quercus.Admin
{
    [Area("Admin")]
    // [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private UserManager<QuercusUser> userManager;
        private RoleManager<IdentityRole> roleManager;

        private Repository<QuercusUser> _data { get; set; }

        public UserController(UserManager<QuercusUser> um, RoleManager<IdentityRole> rm, TreeContext ctx)
        {
            userManager = um;
            roleManager = rm;
            _data = new Repository<QuercusUser>(ctx);
        }

        [HttpGet]
        public async Task<IActionResult> Dash()
        {
            List<QuercusUser> adminUsers = new List<QuercusUser>();

            foreach (QuercusUser user in userManager.Users)
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

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(AdminRegisterAccountViewModel vm)
        {

            if (ModelState.IsValid)
            {
                QuercusUser usertoAdd = new() { ShortUserName = vm.Username, UserName = vm.Username, PasswordHash = vm.Password };

                if (usertoAdd != null)
                {
                    _data.Insert(usertoAdd);
                    _data.Save();
                    return View("AddUserSucess", usertoAdd);
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View();
            }

        }
        public IActionResult AddUserSucess(QuercusUser qu){
            return View(qu);
        }
    }
}