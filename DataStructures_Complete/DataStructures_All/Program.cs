using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_All
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode<int> myLinkedList = new DataStructures_All.LinkedListNode<int>(3);
        }

    }

    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode(T value)
        {
            Value = value;
        }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }

        public void AddFirst(LinkedListNode<T> newNode)
        {
            if (Head != null)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Head = newNode;
            }
        }
        public void AddLast(LinkedListNode<T> newNode)
        {
            LinkedListNode<T> temp = Head;
            while (temp.Next != null)
            {
                temp.Next = temp;
            }
            temp.Next = newNode;
        }
        public void RemoveFirst()
        {
            if (Head != null)
            {
                Head = Head.Next;
            }
            else
            {
                Console.WriteLine("Cant remove as there is no head found...");
            }
        }
        public void RemoveLast()
        {
            LinkedListNode<T> temp = Head;
            while (temp.Next != Tail)
            {
                temp.Next = temp;
            }
            temp.Next = null;
            Tail = temp;
        }


    }
}
