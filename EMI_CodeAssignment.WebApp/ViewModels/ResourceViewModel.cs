using EMI_CodeAssignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMI_CodeAssignment.WebApp.ViewModels
{
    public class ResourceViewModel
    {
        public ProjectTask Task { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Resource> Resources { get; set; }

        public Resource SelectedResource { get; set; }

        public List<ProjectTaskResource> Tasks { get; set; }

        public Guid? TaskId { get; set; }

        public Guid? ResourceId { get; set; }

        public ResourceViewModel()
        {
            Resources = new List<Resource>();
            Tasks = new List<ProjectTaskResource>();
        }
    }
}