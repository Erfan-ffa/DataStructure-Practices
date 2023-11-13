namespace Sort_LinkedList
{
    public class Node
    {
        public int value;
        public Node next;
    }

    public class Operation
    {
        Node head = null;

        private bool IsNull()
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

        public void Insert(int key)
        {
            Node newNode = new Node();
            newNode.value = key;
            if (IsNull())
            {
                head = newNode;
                head.next = null;
            }
            else if (head.next == null && key >= head.value)
            {
                head.next = newNode;
                newNode.next = null;
            }
            else if (key <= head.value)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node finde = head;

                while (finde != null)
                {
                    if (finde.next == null)
                    {
                        finde.next = newNode;
                        newNode.next = null;
                        return;
                    }
                    else if (key >= finde.value && key <= finde.next.value)
                    {
                        newNode.next = finde.next;
                        finde.next = newNode;
                        return;
                    }
                    finde = finde.next;
                }
            }
        }

        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }
    }
}