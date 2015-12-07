using System;


namespace TimeComplexity2
{

    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            System.Int64 n = A.Length;
            int i;
            System.Int64 total;
            total = (n + 1) * (n + 2) / 2;
            for (i = 0; i < n; i++)
            {
                total -= A[i];
            }

            return (int)total;
        }
    }

    // Big O(N) or O(N * Log(N))
}