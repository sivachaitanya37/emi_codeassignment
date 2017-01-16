using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ResourceManager.WebApp.Models
{
    //public class ApplicationUser : IdentityUser
    //{
    //    public ICollection<ApplicationRole> UserRoles { get; set; }
    //    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
    //    {
    //        var userIdentity = await manager.CreateIdentityAsync(this,
    //            DefaultAuthenticationTypes.ApplicationCookie);
    //        return userIdentity;
    //    }
    //}

    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this,
                DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }

}