using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithLinkedList
{
    public class Node
    {
        public int value;
        public Node next;
        public Node prev;
    }

    public class Stacks
    {
        Node head = null;
        Node top;

        public Stacks()
        {
            top = head;
        }

        public bool IsEmpty()
        {
            if (top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Push(int value)
        {
            if (top == null)
            {
                Node newNode = new Node();
                newNode.value = value;
                head = newNode;
                head.next = null;
                head.prev = null;
                top = head;
            }
            else
            {
                Node createdNode = new Node();
                createdNode.value = value;

                top.next = createdNode;
                createdNode.prev = top;
                top = createdNode;
            }
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                Node tempTop = top.prev;
                top = null;
                top = tempTop;
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }


        public void Print()
        {
            if (!IsEmpty())
            {
                Node tempHead = head;
                while (tempHead != top.next)
                {
                    Console.WriteLine(tempHead.value);
                    tempHead = tempHead.next;
                }
            }
            else
            {
                Console.WriteLine("list is emtpy");
            }
        }
    }
}
