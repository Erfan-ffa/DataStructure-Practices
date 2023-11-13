using FindingTheIndexOfElementInArrayWithBinarySearch;

namespace InsertWithBinarySearchInINsertionSort
{
    public class InsertionSort
    {
        RecursiveFinder finder = new RecursiveFinder();
        int j = 1;
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int index = finder.RecursiveFind(array, 0, j - 1, array[i + 1]);
                int tempd = array[i + 1];
                if (index != i + 1)
                {
                    for (int k = i; k >= index; k--)
                    {
                        array[k + 1] = array[k];
                    }
                }
                array[index] = tempd;
                j++;
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}