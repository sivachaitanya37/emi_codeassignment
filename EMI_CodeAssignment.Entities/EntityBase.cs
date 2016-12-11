using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMI_CodeAssignment.Entities
{
    public class EntityBase
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastUpdated { get; set; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
            LastUpdated = DateTime.Now;
        }
    }
}
