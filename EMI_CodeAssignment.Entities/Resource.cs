using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMI_CodeAssignment.Entities
{
    public class Resource : EntityBase
    {
        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Name { get; set; }

        public List<ProjectTaskResource> Tasks { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[Required]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }

        //[Required]
        //[DataType(DataType.PhoneNumber)]
        //public string Mobile { get; set; }

        public Resource()
        {
            Tasks = new List<ProjectTaskResource>();
        }
    }
}
