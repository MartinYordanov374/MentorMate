using System;

namespace MyMathLibrary
{
    public class MathematicalOperationsHelper
    {
        public int Sum(int a, int b)
        {
            return HelpSumNumbers(a, b);
        }

        internal int HelpSumNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
