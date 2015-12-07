using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");


namespace TimeComplexity1
{
    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int totalSum = 0;
            int firstSum = A[0];
            for (int i = 1; i < A.Length; i++)
                totalSum += A[i];

            int min = Math.Abs(firstSum - totalSum);

            for (int i = 1; i < A.Length - 1; i++)
            {
                firstSum += A[i];
                totalSum -= A[i];
                if (Math.Abs(firstSum - totalSum) < min)
                    min = Math.Abs(firstSum - totalSum);

            }
            return min;
        }
    }

    // Big O(n)
}