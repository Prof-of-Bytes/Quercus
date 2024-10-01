#pragma warning disable IDE0130 // Namespace does not match folder structure
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Quercus.Identity;

namespace Quercus.Admin
{


    public class QuercusUser : IdentityUser
    {

        public string ShortUserName { get; set; } = null!;
        
        [NotMapped]
        public IList<string> AssignedRoles { get; set; } = null!;

    }
}