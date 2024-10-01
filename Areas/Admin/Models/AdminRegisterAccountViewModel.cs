using Microsoft.AspNetCore.Identity;
using Quercus.Models;
namespace Quercus.Admin
{

    public class AdminRegisterAccountViewModel : RegisterAccountViewModel
    {
        public List<IdentityRole> Roles { get; set; }

        public AdminRegisterAccountViewModel() : base()
        {

            Roles = [];
        }

    }
}