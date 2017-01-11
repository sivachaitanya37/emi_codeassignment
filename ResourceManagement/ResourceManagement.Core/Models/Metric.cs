using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ResourceManagement.Core.Models
{
    public class Metric : ModelBase
    {
        [StringLength(20, MinimumLength = 2)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
