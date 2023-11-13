namespace ArraySorting
{
    public class SortArray
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minimumIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[minimumIndex] > array[j])
                    {
                        minimumIndex = j;
                    }
                }
                int temp = array[minimumIndex];
                array[minimumIndex] = array[i];
                array[i] = temp;
            }

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}