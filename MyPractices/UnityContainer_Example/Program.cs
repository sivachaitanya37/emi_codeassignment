using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainer_Example
{
    class Program
    {
        public interface ICompany
        {
            void ShowSalary();
        }
        public class Company : ICompany
        {
            public void ShowSalary()
            {
                Console.WriteLine("Your salary is 1.25 Lakhs ");
            }
        }
        public interface IEmployee
        {

        }
        public class Employee : IEmployee
        {
            private ICompany _company;
            [InjectionConstructor]
            public Employee(ICompany company)
            {
                _company = company;
            }

            public void DisplaySalary()
            {
                _company.ShowSalary();
            }
        }
        static void Main(string[] args)
        {
            // Simple Approach
            //Employee emp = new Employee(new Company());
            //emp.DisplaySalary();

            // Approach with Unity Container
            IUnityContainer unity = new UnityContainer();
            unity.RegisterType<ICompany, Company>();

            Employee emp = unity.Resolve<Employee>();
            emp.DisplaySalary();


            Console.ReadLine();
        }
    }
}
