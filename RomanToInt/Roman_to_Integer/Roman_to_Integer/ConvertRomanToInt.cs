using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    public class ConvertRomanToInt
    {
        public int RomanToInt(string s) 
        {
            char[] syambols = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] values = { 1, 5, 10, 50, 100, 500, 1000 };
            int sum = 0;

            if (s.Length == 1) 
            {
                for (int i = 0; i < syambols.Length; i++)
                {
                    if (s == syambols[i].ToString()) 
                    {
                        return values[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    int leftNumber = 0;
                    int rightNumber = 0;

                    for (int j = 0; j < values.Length; j++)
                    {
                        if(syambols[j] == s[i])
                        {
                            leftNumber = values[j];
                        }
                        if (i + 1 != s.Length) 
                        {
                            if (s[i + 1] == syambols[j]) 
                            {
                                rightNumber = values[j];
                                
                            }
                        }
                    }

                    if (leftNumber < rightNumber) 
                    {
                        sum += rightNumber - leftNumber;
                        i++;
                    }
                    else
                    {
                        sum += leftNumber;
                    }
                }
            }

            return sum;
        }
    }
}
