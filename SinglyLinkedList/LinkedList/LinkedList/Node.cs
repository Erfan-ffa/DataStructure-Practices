using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }


    public class NodeOperation
    {
        Node head = new Node() 
        {
            Value = 1,
            Next = null
        };
        Node current;

        public NodeOperation()
        {
            current = head;
            head.Next = current;
        }

        public void Insert(int value)
        {
            Node x = new Node() { Value = value };
            current.Next = x;
            current = x;
        }

        public void print()
        {
            for (Node i = head; i != current.Next;)
            {
                Console.WriteLine(i.Value);
                i = i.Next;
            }

            //var newhead = head;
            //while (newhead != null) 
            //{
            //    Console.WriteLine(newhead.Value);
            //    newhead = newhead.Next;
            //}
        }
    }
}
