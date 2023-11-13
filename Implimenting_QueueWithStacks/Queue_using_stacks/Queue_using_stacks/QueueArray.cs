﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_using_stacks
{
    public class QueueArray
    {
        int[] array1;
        int[] array2;
        int arrayLength;
        int top = -1;
        int top2 = -1;
        Status status = Status.NewPop;

        public QueueArray(int length)
        {
            arrayLength = length;
            array1 = new int[arrayLength];
            array2 = new int[arrayLength];
        }

            
        public bool IsEmtpy()
        {
            if (top == -1)
                return true;
            return false;
        }


        public bool IsFull()
        {
            if (top >= array1.Length - 1)
                return true;
            return false;
        }


        public void Enqueue(int value)
        {
            if (!IsFull())
            {
                top++;
                array1[top] = value;
                status = Status.NewPop;
            }
            else
            {
                Console.WriteLine("queue is full!");
            }

        }


        public void Dequque()
        {
            if (!IsEmtpy())
            {
                if (status == Status.NewPop)
                {

                    for (int i = top; i >= 0; i--)
                    {
                        top2++;
                        array2[top2] = array1[i];
                    }

                    int reuslt = array2[top2];
                    top2--;
                    Console.WriteLine(reuslt);

                    int j = 0;
                    for (int i = top2; i >= 0; i--)
                    {
                        array1[j] = array2[i];
                        j++;
                    }
                    top--;
                    status = Status.Poped;
                }
                else if (status == Status.Poped)
                {
                    int result = array2[top];
                    Console.WriteLine(result);
                    top--;
                    top2--;
                }

            }
            else
            {
                Console.WriteLine("queue is empty! ");
            }
        }

        public void PrintMemebers() 
        {
            if (!IsEmtpy()) 
            {
                int result;
                for (int i = 0; i <= top; i++)
                {
                    result = array1[i];
                    Console.WriteLine(result);
                }
            }
        }

    }

}

public enum Status
{
    NewPop,
    Poped,
}

