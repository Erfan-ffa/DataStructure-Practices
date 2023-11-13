namespace ClimbStairs
{
    public class Soloution
    {
        public int ClimbStairs(int n) 
        {
            int first = 0;
            int second = 1;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }
    }
}
