namespace BinarySearchInTwoDifferentSortedPartOfArray
{
    public class Searching
    {
        public int Search(int[] nums, int target)
        {
            int first = 0;
            int last = nums.Length - 1;
            int middle = (first + last) / 2;
            while (true)
            {
                if (target == nums[middle])
                {
                    return middle;
                }
                else if (first > last)
                {
                    return -1;
                }
                else if (nums[first] <= nums[middle])
                {
                    if (target >= nums[first] && target < nums[middle])
                    {
                        last = middle - 1;
                        middle = (first + last) / 2;
                    }
                    else
                    {
                        first = middle + 1;
                        middle = (first + last) / 2;
                    }
                }
                else
                {
                    if (target > nums[middle] && target <= nums[last])
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
}
