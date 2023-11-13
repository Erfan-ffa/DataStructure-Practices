namespace LinkedListPriority_Queue
{
    public class Node
    {
        public int value;
        public int priority;
        public Node next;
        public Node prev;
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


        public void Enqueue(int value, int priority)
        {
            if (!IsNull())
            {
                Node newNode = new Node();
                newNode.value = value;
                newNode.priority = priority;

                var tempNode = head;

                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                tempNode.next = newNode;
                newNode.prev = tempNode;

            }
            else
            {
                Node newNode = new Node();
                newNode.value = value;
                newNode.priority = priority;
                newNode.next = null;
                head = newNode;
            }
        }

        public void Dequeue()
        {
            if (!IsNull())
            {
                Node tempHead = head;
                Node min = tempHead;

                while (tempHead.next != null)
                {
                    tempHead = tempHead.next;
                    if (min.priority > tempHead.priority)
                    {
                        min = tempHead;
                    }
                }

                if (min == head)
                {
                    tempHead = head.next;
                    head = null;
                    head = tempHead;
                }
                else if (min.next == null)
                {
                    min.prev.next = null;
                }
                else
                {
                    min.prev.next = min.next.prev;
                    min.next.prev = min.prev.next;
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
                    Console.WriteLine($"value : {current.value} - priority {current.priority}");
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
