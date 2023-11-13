using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
    public static class Calculator
    {
        public static UInt64 CalculateFact(UInt64 number) 
        {
            if (number == 0 || number == 1) return 1;

            UInt64 factResult = number * CalculateFact(number - 1);
            return factResult;
        }

        public static UInt64 CalculatePower(UInt64 exponent, UInt64 baseNum)
        {
            if (baseNum == 0) return 1;
            if (exponent == 1) return baseNum;

            UInt64 powerResult = exponent * CalculatePower(exponent, baseNum - 1);
            return powerResult;
        }
    }
}
