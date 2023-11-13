using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLinkedList
{
    internal class Node
    {
        public int value;
        public Node next;
    }

    public class Operation
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

        public void Enqueue(int value)
        {
            if (!IsNull())
            {
                Node newNode = new Node();
                Node tempNode = head;

                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                newNode.value = value;
                tempNode.next = newNode;

            }
            else
            {
                Node newNode = new Node();
                newNode.value = value;
                newNode.next = null;
                head = newNode;
            }
        }

        public void SortLinkedList()
        {
            if (!IsNull())
            {
                var tempHead = head;

                for (Node i = tempHead; i != null; i = i.next)
                {
                    for (Node j = i.next; j != null; j = j.next)
                    {
                        if (i.value > j.value) 
                        {
                            var temp = j.value;
                            j.value = i.value;
                            i.value = temp;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Queue Is Null!");
            }
        }
        public void Print()
        {
            if (!IsNull())
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine($"value : {current.value}");
                    current = current.next;
                }
            }
            else
            {
                Console.WriteLine("Queue Is Null!");
            }
        }

    }

}
