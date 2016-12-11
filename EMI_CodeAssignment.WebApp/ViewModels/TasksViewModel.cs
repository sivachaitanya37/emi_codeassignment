using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMI_CodeAssignment.WebApp.ViewModels
{
    public class TasksViewModel
    {
        public List<ProjectTask> Tasks { get; set; }

        public ProjectTask SelectedTask { get; set; }

        public List<ProjectTaskResource> Resources { get; set; }

        public TasksViewModel()
        {
            Tasks = new List<ProjectTask>();
            Resources = new List<ProjectTaskResource>();
        }
    }
}