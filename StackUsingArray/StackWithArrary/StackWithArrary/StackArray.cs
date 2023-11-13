using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithArrary
{
    public class StackArray
    {
        int[] numbers;
        int top = -1;
        int sizeArray;
        public StackArray(int size)
        {
            sizeArray = size;
            numbers = new int[sizeArray];
        }

        public bool IsEmpty()
        {
            if (top == -1)
                return true;
            return false;
        }


        public bool IsFull()
        {
            if (top == sizeArray - 1)
                return true;
            return false;
        }


        public void Push(int num)
        {
            if (!IsFull())
            {
                top++;
                numbers[top] = num;
            }
            else
            {

                Console.WriteLine("stack is full");
            }
        }

        public int Pop()
        {
            if (!IsEmpty())
            {
                int popedItem = numbers[top];
                top--;
                return popedItem;
            }
            return -1;
        }

        public void PrintStackMemebers()
        {
            if (!IsEmpty())
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(numbers[i]);
                }
                
            }
            else
            {
                Console.WriteLine("stack is empty");
            }
        }

        public int Peek() 
        {
            if (!IsEmpty())
            {
                int popedItem = numbers[top];
                return popedItem;
            }
            return -1;
        }


    }
}
