using EMI_CodeAssignment.Business.Core;
using EMI_CodeAssignment.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI_CodeAssignment.Business.Tests.Classes
{
    public class EntityRepo : RepositoryBase<Entity>
    {
        public EntityRepo(IDataContext db)
            : base(db)
        {

        }
    }
}
