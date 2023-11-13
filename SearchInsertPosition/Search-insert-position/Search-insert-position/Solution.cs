namespace Search_insert_position
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            return RecursiveFind(nums, 0, nums.Length - 1, target);
        }
        public int RecursiveFind(int[] array, int first, int last, int key)
        {
            int middle = (first + last) / 2;
            if (first > last)
            {
                return first;
            }
            else if (first == last)
            {
                if (key < array[first] || key == array[last])
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
                return middle;
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
