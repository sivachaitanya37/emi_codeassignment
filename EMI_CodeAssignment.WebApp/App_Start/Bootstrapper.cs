using EMI_CodeAssignment.Business;
using EMI_CodeAssignment.Business.Database;
using EMI_CodeAssignment.Business.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMI_CodeAssignment.WebApp.App_Start
{
    public class Bootstrapper
    {
        static UnityContainer container;

        public static void Initialize()
        {
            container = new UnityContainer();
            container.
                RegisterType<IDataContext, EMI_CodeAssignmentDb>(new PerRequestLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}