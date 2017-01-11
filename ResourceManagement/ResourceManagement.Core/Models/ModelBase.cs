using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Core.Models
{
    public class ModelBase
    {
        [Key]
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Index { get; set; }

        public ModelBase(Guid id = new Guid())
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
        }
    }
}
