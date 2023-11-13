namespace LinkedList
{
    public class Node
    {
        public int Value;
        public Node Next;
        public int indexCounter;
    }

    public class NodeOperation
    {
        Node head = null;
        Node last = null;
        int counter = 0;

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


            if (IsNull())
            {
                Node newNode = new Node();
                head = newNode;
                head.Value = value;
                head.Next = null;
                newNode.indexCounter = ++counter;
                last = head;
            }
            else
            {
                Node newNode = new Node();
                newNode.indexCounter = ++counter;
                Node tempHead = head;
                newNode.Value = value;
                newNode.Next = tempHead;
                head = newNode;
                last = head.Next;
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
                last = head;
                newNode.indexCounter = ++counter;
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
                last = newNode;
                newNode.indexCounter = ++counter;

            }
        }

        int GetArrayLength(Node start, Node end)
        {
            if (start == end)
            {
                return 0;
            }
            else
            {
                return 1 + GetArrayLength(start.Next, end);
            }
        }

        public int BinarySearchs(int key)
        {
            if (!IsNull())
            {
                Node front = head;
                Node lastItem = last;
                int middle = (GetArrayLength(front, last) / 2) + 1;
                Node middleNode = head;
                int counter = 0;


                while (true)
                {
                    counter++;
                    for (int i = 1; i < middle; i++)
                    {
                        middleNode = middleNode.Next;
                    }
                    if (key > last.Value)
                    {
                        Console.Write("Item Not Found , has exited code : ");
                        return -1;
                    }
                    else if (key == middleNode.Value)
                    {
                        Console.WriteLine("Totoal Of compares : " + counter);
                        return middleNode.Value;
                    }
                    else if (front.Next.Next == lastItem)
                    {
                        Console.WriteLine("Totoal Of compares : " + counter);
                        return front.Next.Next.Value;
                    }
                    else if (front == lastItem)
                    {
                        return front.Value;
                    }
                    else if (key > middleNode.Value)
                    {
                        front = middleNode;
                        middleNode = front;
                        middle = (GetArrayLength(front, lastItem) / 2) + 1;
                    }
                    else
                    {
                        lastItem = middleNode;
                        middleNode = front;
                        middle = (GetArrayLength(front, lastItem) / 2) + 1;
                    }
                }
            }
            else
            {
                Console.WriteLine("empty!!");
                return -1;
            }
        }

        public void Print()
        {
            var tempNode = head;
            while (tempNode != null)
            {
                Console.WriteLine($"{tempNode.Value} : {tempNode.indexCounter}");
                tempNode = tempNode.Next;
            }

        }
    }
}
