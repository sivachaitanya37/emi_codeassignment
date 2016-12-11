using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMI_CodeAssignment.WebApp.Helpers
{
    public class ValidationHelper
    {
        public static bool ValidateDateRange(List<ProjectTaskResource> tasks, DateTime startDate, DateTime endDate)
        {
            bool isValid = true;

            foreach (var task in tasks)
            {
                isValid = endDate < task.StartDate || startDate > task.EndDate;
                if (!isValid)
                {
                    break;
                }
            }

            return isValid;
        }
    }
}