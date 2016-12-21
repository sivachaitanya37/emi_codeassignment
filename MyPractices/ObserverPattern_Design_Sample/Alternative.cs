using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_Design_Sample
{
    class Alternative
    {
        public static void Main(string[] args)
        {
            IBM ibm = new ObserverPattern_Design_Sample.IBM(100, "IBM");
            ibm.Attach(new Investor("Investor1"));
            ibm.Attach(new Investor("Investor2"));
            ibm.Attach(new Investor("Investor3"));

            ibm.Price = 200;
            Console.ReadLine();

        }
    }
    class IBM : Stock
    {
        public IBM(double price, string name) : base(price, name)
        {
        }
    }
    class Stock
    {
        private double _price;
        private string _name;
        public List<Investor> _investors = new List<Investor>();
        public Stock(double price, string name)
        {
            _price = price;
            _name = name;
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }
        public string Name
        {
            get { return _name; }
        }

        public void Attach(Investor investor)
        {
            _investors.Add(investor);
        }
        public void Detach(Investor investor)
        {
            _investors.Remove(investor);
        }
        public void Notify()
        {
            foreach (Investor investor in _investors)
            {
                investor.Update(this);
            }
        }
    }
    class Investor
    {
        private string _name;
        public Stock Stock { get; set; }
        public Investor(string name)
        {
            _name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine($"Given stock :{stock.Name}: update to :{stock.Price}: and notified to :{_name}: investor");
        }
    }
}
