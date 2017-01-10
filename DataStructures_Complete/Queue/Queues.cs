using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queues
    {
        private class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }

        private Node head; //Remove items from head
        private Node tail; //Add items to tail

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Peek()
        {
            return head.data;
        }
        public void Add(int data)
        {
            Node newItem = new Node(data);
            if (tail != null)
            {
                tail.next = newItem;
            }
            if (head == null)
            {
                head = newItem;
            }
        }
        public int Remove()
        {
            int data = head.data;
            head = head.next;
            if (head == null)
            {
                tail = null;
            }
            return data;
        }

    }
}


