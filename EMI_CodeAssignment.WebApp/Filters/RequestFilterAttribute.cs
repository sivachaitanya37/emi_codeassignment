using EMI_CodeAssignment.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMI_CodeAssignment.WebApp.Filters
{
    public class RequestFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            // Adding DataContext to request scope...
            filterContext.RequestContext.HttpContext.Items["EMI_DataContext"] = new EMI_CodeAssignmentDb();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
    }
}