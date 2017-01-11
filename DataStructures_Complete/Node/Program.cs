using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node() { Value = 3 };
            Node middle= new Node() { Value = 5 };
            first.Next = middle;

            Node last= new Node() { Value = 7 };
            middle.Next = last;

            while (first!=null)
            {
                Console.WriteLine(first.Value);
                first = first.Next;
            }
            Console.ReadLine();
        }
    }
}
