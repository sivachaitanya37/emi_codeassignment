using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ResourceManager.WebApp.Models
{
    public class ApplicationUserRole : IdentityUserRole
    {
        public ApplicationUserRole() : base() { }
        public ApplicationRole Role { get; set; }
    }
}