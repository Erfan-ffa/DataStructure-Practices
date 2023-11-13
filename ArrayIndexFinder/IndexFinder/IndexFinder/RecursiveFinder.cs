namespace FindingTheIndexOfElementInArrayWithBinarySearch
{
    public class RecursiveFinder
    {
        public int RecursiveFind(int[] array, int first, int last, int key)
        {
            int middle = (first + last) / 2;
            if (first > last)
            {
                return first;
            }
            else if (first == last)
            {
                if (key < array[first])
                {
                    return last;
                }
                else
                {
                    return last + 1;
                }
            }
            else if (key == array[middle])
            {
                return middle + 1;
            }
            else if (key > array[middle])
            {
                return RecursiveFind(array, middle + 1, last, key);
            }
            else
            {
                return RecursiveFind(array, first, middle - 1, key);
            }
        }
    }
}
