namespace FindingTheIndexOfElementInArrayWithBinarySearch
{
    public class IterativeFinder
    {
        int first = 0;
        int last;
        int midddle;
        public void Finde(int[] array, int key)
        {
            last = array.Length - 1;
            midddle = (first + last) / 2;
            while (first - 1 == midddle || last - 1 != midddle)
            {
                if (key == array[midddle])
                {
                    Console.WriteLine(midddle + 1);
                    return;
                }
                else if (last == first && last == midddle && first == midddle)
                {
                    if (key < array[last])
                    {
                        Console.WriteLine(last);
                    }
                    else
                    {
                        Console.WriteLine(last + 1);

                    }
                    return;
                }
                else if (key > array[midddle])
                {
                    first = midddle + 1;
                }
                else if (key < array[midddle])
                {
                    last = midddle - 1;
                }

                midddle = (first + last) / 2;
            }


            if (key > array[first] && key < array[last])
            {
                Console.WriteLine(last);
            }
            else if (key > array[last])
            {
                Console.WriteLine(last + 1);
            }
            else
            {
                Console.WriteLine(midddle);
            }

        }

    }
}