public class Node
{
    public int value;
    public Node next;
}

public class SortingLinkedList
{
    Node head = null;

    public bool IsNull()
    {
        return head == null;
    }

    public void Insert(int value)
    {
        if (!IsNull())
        {
            Node newNode = new Node();
            newNode.value = value;

            Node tempNode = head;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }

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


    public void BubbleSort()
    {
        if (!IsNull())
        {
            for (Node temp = head; temp != null; temp = temp.next)
            {
                for (Node i = head; i.next != null; i = i.next)
                {
                    if (i.value > i.next.value)
                    {
                        int tempValue = i.value;
                        i.value = i.next.value;
                        i.next.value = tempValue;

                        /* using tuple to swap
                        (i.value, i.next.value) = (i.next.value, i.value); */
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Array is null!");
        }
    }


    public void SelectionSort()
    {
        if (!IsNull()) 
        {
            Node tempNode = head;
            for (tempNode = head; tempNode != null; tempNode = tempNode.next)
            {
                Node minimumNode = tempNode;
                for (Node i = tempNode.next; i != null; i = i.next)
                {
                    if (minimumNode.value > i.value)
                    {
                        minimumNode = i;
                    }
                }
                int tempValue = tempNode.value;
                tempNode.value = minimumNode.value;
                minimumNode.value = tempValue;
            }
        }
        else
        {
            Console.WriteLine("Array is null");
        }
    }


    public void Print()
    {
        if (!IsNull())
        {
            Node tempHead = head;
            while (tempHead != null)
            {
                Console.WriteLine(tempHead.value);
                tempHead = tempHead.next;
            }
        }
        else
        {
            Console.WriteLine("Array is null");
        }
    }

}