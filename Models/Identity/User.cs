#pragma warning disable IDE0130 // Namespace does not match folder structure
using Microsoft.AspNetCore.Identity;

namespace Quercus.Identity{
#pragma warning restore IDE0130 // Namespace does not match folder structure

    public class User: IdentityUser{
        public string ShortUserName {get; set;}
        
    }
}