using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class OptimizedBubbleSort
    {
        public void SortArray(int[] array)
        {
            bool IsMoved = true;
            int counter = 0;
            do
            {
                IsMoved  = false;
                int len = array.Length - 1;
                for (int j = 0; j < len; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        IsMoved  = true;
                    }
                }
                len--;
                counter++;
            } while (IsMoved);


            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
