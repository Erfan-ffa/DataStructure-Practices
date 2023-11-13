using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    public class Reverser
    {
        public bool IsPalindrome(int x)
        {
            int reverse = 0;
            int remain = 0;
            int num = x;

            if (num < 0)
            {
                return false;
            }
            else
            {
                while (num > 0)
                {
                    remain = num % 10;
                    reverse = (reverse * 10) + remain;
                    num = num / 10;
                }

                if (reverse == x)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
