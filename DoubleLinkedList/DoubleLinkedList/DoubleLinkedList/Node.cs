using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class Node
    {
        public int value;
        public Node next;
        public Node prev;
    }

    public class LinkedListOperation
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


        public void InsertAtFirst(int value)
        {
            if (IsNull())
            {
                Node newNode = new Node();

                newNode.value = value;
                newNode.next = null;
                newNode.prev = null;

                head = newNode;
            }
            else
            {
                Node newNode = new Node();
                newNode.value = value;

                newNode.next = head;
                newNode.prev = null;
                head.prev = newNode;

                head = newNode;
            }
        }

        public void InsertAtLast(int value)
        {
            if (IsNull())
            {
                Node newNode = new Node();

                newNode.value = value;
                newNode.next = null;
                newNode.prev = null;

                head = newNode;
            }
            else
            {
                Node newNode = new Node();
                newNode.value = value;

                Node lastFoundNode = head;
                while (lastFoundNode.next != null)
                {
                    lastFoundNode = lastFoundNode.next;
                }

                newNode.prev = lastFoundNode;
                newNode.next = null;
                lastFoundNode.next = newNode;
            }
        }

        public void InsertAfter(int index, int value)
        {
            if (!IsNull())
            {
                Node newNode = new Node();
                Node foundNode = FindNodeRecursive(head,index);

                if (foundNode == null) 
                {
                    Console.WriteLine("Item not found");
                }
                else if (foundNode.next == null)    
                {
                    InsertAtLast(value);
                }
                else
                {
                    newNode.next = foundNode.next;
                    foundNode.next = newNode;
                    newNode.prev = foundNode;
                    newNode.value = value;
                }
            }
            else
            {
                Console.WriteLine("An error occurred");
            }
        }

        public void DeleteFromFirst()
        {
            if (!IsNull())
            {
                Node tempNode = head.next;
                head = null;
                head = tempNode;
            }
            else
            {
                Console.WriteLine("there is nothing to delete!");
            }
        }

        public void DeleteFromLast()
        {
            if (!IsNull())
            {
                if (head.next == null)
                {
                    head = null;
                }
                else
                {
                    Node lastNode = head;

                    while (lastNode.next.next != null)
                    {
                        lastNode = lastNode.next;

                    }
                    lastNode.next = null;
                }
            }
            else
            {
                Console.WriteLine("there is nothing to delete!");
            }
        }
 
        public void DeleteAt(int popedItemValue)
        {
            if (!IsNull())
            {

                if (popedItemValue == head.value)
                {
                    DeleteFromFirst();
                }
                else
                {
                    Node foundNode = FindNodeRecursive(head, popedItemValue);

                    if (foundNode == null) 
                    {
                        Console.WriteLine("Item Not Found!");
                    }
                    else if (foundNode.next == null)
                    {
                        foundNode.prev.next = null;
                    }
                    else
                    {
                        foundNode.prev.next = foundNode.next;
                        foundNode.next.prev = foundNode.prev;
                    }
                }
            }
            else
            {
                Console.WriteLine("there is nothing in order to delete!");
            }
        }

        public Node FindNodeRecursive(Node start, int value)
        {
            Node result = null;

            if (start == null)
            {
                return null;
            }
            if (start.value == value)
            {
                result = start;
            }
            else
            {
                return FindNodeRecursive(start.next, value);
            }
            return result;
        }

        public void Print()
        {
            if (!IsNull())
            {
                Node tempNode = head;
                while (tempNode != null)
                {
                    Console.WriteLine(tempNode.value);
                    tempNode = tempNode.next;
                }
            }
        }
    }
}
