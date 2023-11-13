namespace CircularLinkedList
{
    public class Node
    {
        public int value;
        public Node next;
        public Node prev;
    }

    public class Operation
    {
        Node head = null;
        Node lastItem = null;

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
            if (IsNull())
            {
                Node createdNode = new Node();
                createdNode.value = value;
                createdNode.next = createdNode;
                createdNode.prev = createdNode;
                head = createdNode;
                lastItem = head;
            }
            else
            {
                Node createdNode = new Node();
                createdNode.value = value;

                lastItem.next = createdNode;
                createdNode.prev = lastItem;
                createdNode.next = head;
                lastItem = createdNode;
            }
        }

        public void Dequeue()
        {
            if (!IsNull())
            {
                if (lastItem == head)
                {
                    head = null;
                }
                else
                {
                    var temp = head.next;
                    head = null;
                    temp.prev = lastItem;
                    head = temp;
                    lastItem.next = temp;
                }
            }
            else
            {
                Console.WriteLine("List Is Null!");
            }
        }


        public void Print()
        {
            if (!IsNull())
            {
                // First solution
                Console.WriteLine(head.value);
                var temp = head.next;
                while (temp != head)
                {
                    Console.WriteLine(temp.value);
                    temp = temp.next;
                }


                // Second solution
                //var temp = head;
                //while (true)
                //{
                //    Console.WriteLine(temp.value);
                //    temp = temp.next;
                //    if (temp.next == head)
                //    {
                //        Console.WriteLine(temp.value);
                //        break;
                //    }
                //}
            }
            else
            {
                Console.WriteLine("List Is Null!");
            }
        }

    }

}
