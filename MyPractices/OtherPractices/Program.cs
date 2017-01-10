using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherPractices
{
    interface IEmployee
    {
        int EmployeeId { get; set; }
        string EmployeeName { get; set; }

    }
    class Program : IEmployee
    {
        public int EmployeeId
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string EmployeeName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
