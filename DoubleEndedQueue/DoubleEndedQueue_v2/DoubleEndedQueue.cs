using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue_v2
{
    public class DoubleEndedQueue
    {
        int front = -1;
        int rear;
        int[] array;

        public DoubleEndedQueue(int len)
        {
            array = new int[len];
            rear = len;
        }


        public bool IsEmpty()
        {
            if (rear == array.Length && front == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (rear == front + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EnqueueFront(int value)
        {
            if (!IsFull())
            {
                front++;
                array[front] = value;
            }
            else
            {
                Console.WriteLine("Array is full!");
            }
        }


        public void EnqueueRear(int value)
        {
            if (!IsFull())
            {
                rear--;
                array[rear] = value;
            }
            else
            {
                Console.WriteLine("Array is full!");
            }
        }

        public void DequeueFront()
        {
            if (IsEmpty() || front == -1)
            {
                Console.WriteLine("Array is empty to pop from front");
            }
            if (!IsEmpty())
            {
                int result = array[front];
                Console.WriteLine(result);
                front--;
            }

        }

        public void DequeueRear()
        {
            if (rear == array.Length || IsEmpty())
            {
                Console.WriteLine("Array is empty to pop from back");
            }
            else
            {
                int result = array[rear];
                Console.WriteLine(result);
                rear++;
            }
        }


        public void Print()
        {
            if (!IsEmpty())
            {
                for (int i = 0; i <= front; i++)
                {
                    Console.WriteLine(array[i]);
                }
                for (int i = array.Length - 1; i >= rear; i--)
                {
                    Console.WriteLine(array[i]);
                }
            }
            else
            {
                Console.WriteLine("Array is empty to print");
            }
        }
    }
}
