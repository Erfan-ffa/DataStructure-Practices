namespace System
{
    public class CircQueue
    {
        int rear = -1;
        int front = -1;
        int[] array;

        public CircQueue(int size)
        {
            array = new int[size];
        }


        public bool IsEmpty()
        {
            if (front == -1)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if ((front == 0 && rear == array.Length - 1) || front == rear + 1)
            {
                return true;
            }
            return false;
        }

        public void Enqueue(int value)
        {
            if (!IsFull())
            {
                if (front == -1)
                {
                    front = 0;
                }
                rear = (rear + 1) % array.Length;
                array[rear] = value;

            }
            else
            {
                Console.WriteLine("queue is full");
            }
        }

        public void Dequeue()
        {
            if (!IsEmpty())
            {
                Console.WriteLine(array[front]);
                if (rear == front)
                {
                    rear = -1;
                    front = -1;
                }
                else
                {
                    front = (front + 1) % array.Length;
                }
            }
            else
            {
                Console.WriteLine("queue is empty");
            }
        }
    }
}