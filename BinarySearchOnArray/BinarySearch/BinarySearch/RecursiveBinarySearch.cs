namespace BinarySearch
{
    public class IterativeBinarySearch
    {
        int[] arr = new int[] { 1, 2, 3, 4 };
        int first;
        int last;
        int middle;

        public IterativeBinarySearch()
        {
            last = arr.Length - 1;
            first = 0;
            middle = (first + last) / 2;
        }

        public void BinarySearchs(int key)
        {
            while (true)
            {
                Console.WriteLine("-" + counter);

                if (key == arr[middle])
                {
                    Console.WriteLine(middle);
                    return;
                }
                else if (last == first)
                {
                    Console.WriteLine("Item Not Found!");
                    return;
                }
                else if (key > arr[middle])
                {
                    first = middle + 1;
                    middle = (first + last) / 2;
                }
                else
                {
                    last = middle - 1;
                    middle = (first + last) / 2;
                }

            }
        } 
    }
}
