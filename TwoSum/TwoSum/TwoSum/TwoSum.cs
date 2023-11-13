namespace TwoSum_v1
{
    public class TwoSum
    {
        public int[] TwoSumFinder(int[] nums, int target)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        firstIndex = i;
                        secondIndex = j;
                        break;
                    }
                }
            }
            result[0] = nums[firstIndex];
            result[1] = nums[secondIndex];
            return result;
        }
    }
}
