public class QueueArray
{
    int[] numArray;
    int arrayLength;
    int front = 0;
    int rear = -1;


    public QueueArray(int SizeArray)
    {
        arrayLength = SizeArray;
        numArray = new int[arrayLength];
    }

    bool IsFull()
    {
        if (rear >= arrayLength)
            return true;
        return false;
    }

    bool IsEmpty()
    {
        if (rear == -1)
            return true;
        return false;
    }


    public void Enqueue(int Num)
    {
        if (!IsFull())
        {
            rear++;
            numArray[rear] = Num;
        }
        else
        {
            Console.WriteLine("Queue is full!");
        }
    }

    public void Dequeue()
    {
        if (!IsEmpty())
        {
            int j = 0;
            int i;
            for (i = front + 1; i <= rear; i++)
            {
                numArray[j] = numArray[i];
                j++;
            }
            rear = j - 1;
            front = 0;
        }
        else
        {
            Console.WriteLine("array is empty");
        }
    }

    public void PrintMembers()
    {
        if (!IsEmpty())
        {
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(numArray[i]);
            }
        }
    }

}