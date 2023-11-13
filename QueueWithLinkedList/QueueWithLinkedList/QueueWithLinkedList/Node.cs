namespace QueueWithLinkedList
{
    public class Node
    {
        public int value;
        public Node next;
    }

    public class QueueLinkedList
    {
        Node head = null;
        Node rear = null;

        public bool IsNull()
        {
            if (head == null || rear == null)
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
            if (IsNull())
            {
                Node newNode = new Node();
                newNode.value = value;
                head = newNode;
                head.next = null;
                rear = head;
            }
            else
            {
                Node newNode = new Node();
                newNode.value = value;
                rear.next = newNode;
                rear = newNode;
            }
        }

        public void Dequeue()
        {
            if (!IsNull())
            {
                Node tempNode = head.next;
                head = null;
                head = tempNode;
            }
            else
            {
                Console.WriteLine("queue is empty");
            }
        }

        public void PrintMembers()
        {
            if (!IsNull())
            {
                for (Node i = head; i != rear.next; i = i.next)
                {
                    Console.WriteLine(i.value);
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }

    }
}
