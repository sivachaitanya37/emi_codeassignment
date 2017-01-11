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

        public int Count { get; set; }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> newNode)
        {
            LinkedListNode<T> tempNode = Head;
            Head = newNode;
            Head.Next = tempNode;
            Count++;
            if (Count == 1)
            {
                Head = Tail;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        public void AddLast(LinkedListNode<T> newNode)
        {
            if (Count == 0)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }
            Tail = newNode;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
                if (Count == 0)
                {
                    Head = Tail;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = Tail = null;
                }
                else
                {
                    LinkedListNode<T> presentNode = Head;
                    while (presentNode.Next != Tail)
                    {
                        presentNode = presentNode.Next;
                    }
                    presentNode.Next = null;
                    Tail = presentNode;
                }
            }
        }

        public void Add(T value)
        {
            AddFirst(value);
        }

        public bool Contains(T value)
        {
            while (Head != null)
            {
                if (Head.Value.Equals(value))
                {
                    return true;
                }
                Head = Head.Next;
            }
            return false;
        }

        public void Remove(T value)
        {
            if (Count != 0)
            {
                if (Count == 1 && Head.Value.Equals(value))
                {
                    Head = Tail = null;
                }
                else
                {
                    LinkedListNode<T> previousNode = null;
                    LinkedListNode<T> currentNode = Head;
                    while (currentNode != null)
                    {
                        if (currentNode.Value.Equals(value))
                        {
                            RemoveFirst();
                        }
                        else
                        {
                            if (previousNode != null)
                            {
                                previousNode.Next = currentNode.Next;
                                if (currentNode.Next == null)
                                {
                                    Tail = currentNode;
                                }
                                Count--;
                            }
                        }
                        previousNode = currentNode;
                        currentNode = currentNode.Next;
                    }
                }
            }
        }
    }
}
