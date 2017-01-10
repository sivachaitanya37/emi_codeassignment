using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Stacks
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }
        public Node top;

        public bool IsEmpty()
        {
            return top == null;
        }
        public int Peek()
        {
            return top.data;
        }

        public void Push(int data)
        {
            Node newItem = new Queue.Stacks.Node(data);
            newItem.next = top;
            top = newItem;
        }
        public int Pop()
        {
            int data = top.data;
            top = top.next;
            return data;
        }
    }
}
