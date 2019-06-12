using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerProblems.Problems
{
    class Problem1
    {
        private static float Result;

        public float MultiplesOf3and5()
        {
            Result = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Result += i;
                }
            }

            return Result;
        }
    }
}
