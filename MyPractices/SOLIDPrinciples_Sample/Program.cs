using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples_Sample
{
    interface IDatabase
    {
        void Add();
    }
    //'I'
    interface IDatabaseV1
    {
        void Read();
    }
    interface IDiscount
    {
        double GetDiscount(double cost);
    }

    interface ILogger
    {
        void LogMessage(string message);
    }
    class Customer : IDatabase, IDiscount
    {
        public ILogger iLog;
        public Customer()
        {

        }
        public Customer(ILogger log)
        {
            iLog = log;
        }
        public int TypeOfCustomer { get; set; }
        GeneralLogger log = new GeneralLogger();
        public virtual void Add()
        {
            try
            {
                // Some Db operation goes here
                throw new Exception("Test Exception");
            }
            catch (Exception ex)
            {
                // Violation of 'S' Single Responsibility
                //System.IO.File.WriteAllText(@"E:\DoNotDelete_Siva_All\Source\Repos\NewRepo\MyPractices\SOLIDPrinciples_Sample\SOLIDPrinciples_Sample_Files\Exceptions.txt"
                //, ex.Message);
                log.LogMessage(ex.Message);

                //'D'
                iLog.LogMessage(ex.Message);
            }
        }

        // Violation of 'O' open close 
        //public virtual double GetDiscount(double cost)
        //{
        //    if (TypeOfCustomer == 1)
        //    {
        //        return cost - 100;
        //    }
        //    else
        //    {
        //        return cost - 50;
        //    }
        //}
        //'O'
        public virtual double GetDiscount(double cost) { return cost; }
    }
    //'I'
    class CustomerWithRead : IDatabaseV1
    {
        public void Read()
        {
            //;
        }
    }
    //'O'
    //class GoldCustomer : Customer
    class GoldCustomer : Customer
    {
        public override double GetDiscount(double cost)
        {
            return base.GetDiscount(cost) - 100;
        }
    }
    //'O'
    //class SilverCustomer : Customer
    class SilverCustomer : Customer
    {
        public override double GetDiscount(double cost)
        {
            return base.GetDiscount(cost) - 50;
        }
    }

    //'L'
    //class Enquire : Customer
    class Enquire : IDiscount
    {
        public double GetDiscount(double cost)
        {
            return cost - 5;
        }
    }

    //'D'
    class GeneralLogger : ILogger
    {
        // As part of 'S' Single Responsibility 
        public void LogMessage(string message)
        {
            System.IO.File.WriteAllText(@"E:\DoNotDelete_Siva_All\Source\Repos\NewRepo\MyPractices\SOLIDPrinciples_Sample\SOLIDPrinciples_Sample_Files\Exceptions.txt"
                                                , message);
        }
    }
    //'D'
    class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            // Log to file
        }
    }
    //'D'
    class EmailLogger : ILogger
    {
        public void LogMessage(string message)
        {
            // Log to Email
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Customer cust = new Customer();
            //cust.Add();

            //'L'
            List<Customer> customers = new List<Customer>();
            customers.Add(new GoldCustomer());
            customers.Add(new SilverCustomer());
            //'L' will no longer be of type Customer as it is IDiscount type
            //customers.Add(new Enquire());

            foreach (Customer cust in customers)
            {
                //'L' hits exception as Add() is not implemented for Enquire class
                cust.Add();
            }


            //'I'
            IDatabase db = new Customer();
            db.Add();
            //'I'
            IDatabaseV1 dbV1 = new CustomerWithRead();
            dbV1.Read();


            Console.ReadLine();
        }
    }
}
