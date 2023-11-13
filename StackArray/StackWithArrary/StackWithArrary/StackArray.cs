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
            if (top > sizeArray)
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
        }

        public int Pop()
        {
            if (!IsEmpty())
                return -1;
            int popedItem = numbers[top];
            top--;
            return popedItem;
        }

        public void PrintStackMemebers()
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
