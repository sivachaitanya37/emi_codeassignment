﻿using System.Web;
using System.Web.Mvc;

namespace EMI_CodeAssignment.WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
