using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_CodeAssignment.Entities
{
    public class ProjectTaskResource : EntityBase
    {
        public Guid TaskId { get; set; }
        public ProjectTask Task { get; set; }

        public Guid ResourceId { get; set; }
        public Resource Resource { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
