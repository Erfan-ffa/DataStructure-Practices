using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int Value;
        public Node Next;
    }

    public class NodeOperation
    {
        Node head = null;

        public bool IsNull() 
        {
            if (head == null) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void InsertNodeAtFirst(int value) 
        {
            Node newNode = new Node();

            if (IsNull()) 
            {
                head = newNode;
                head.Value = value;
                head.Next = null;
            }
            else
            {
                Node tempHead = head;
                newNode.Value = value;
                newNode.Next = tempHead;
                head = newNode;
            }
        }


        public void InsertNodeAtLast(int value)
        {
            if (IsNull()) 
            {
                Node newNode = new Node();
                newNode.Value = value;
                newNode.Next = null;
                head = newNode;
            }
            else
            {
                Node newNode = new Node();
                
                Node lastFoundNode = head;
                
                while (lastFoundNode.Next != null)
                {
                    lastFoundNode = lastFoundNode.Next;
                }

                lastFoundNode.Next = newNode;
                newNode.Value = value;
                
            }
        }

        public void Print()
        {
            var tempNode = head;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Value);
                tempNode = tempNode.Next;
            }
        }
    }
}
