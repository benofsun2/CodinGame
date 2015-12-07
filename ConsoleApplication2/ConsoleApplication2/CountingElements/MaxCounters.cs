using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");




namespace MaxCounters
{
    class Solution
    {
        public int[] solution(int N, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] counters = new int[N];
            counters.Initialize();

      
            for (int idx = 0; idx < A.Length; idx++ )
            {
                if (A[idx] <= counters.Length)
                    counters[A[idx]-1]++;
                else
                    counters = Enumerable.Repeat(counters.Max(), N).ToArray();
            }

                return counters;
        }


        public int[] solution2(int N, int[] A)
        {
            int[] result = new int[N];
            int maximum = 0;
            int resetLimit = 0;

            for (int K = 0; K < A.Length; K++)
            {
                if (A[K] < 1 || A[K] > N + 1)
                    throw new InvalidOperationException();

                if (A[K] >= 1 && A[K] <= N)
                {
                    if (result[A[K] - 1] < resetLimit)
                    {
                        result[A[K] - 1] = resetLimit + 1;
                    }
                    else
                    {
                        result[A[K] - 1]++;
                    }

                    if (result[A[K] - 1] > maximum)
                    {
                        maximum = result[A[K] - 1];
                    }
                }
                else
                {
                    // inefficiency here
                    //for (int i = 0; i < result.Length; i++)
                    //    result[i] = maximum;
                    resetLimit = maximum;
                }
            }

            for (int i = 0; i < result.Length; i++)
                result[i] = Math.Max(resetLimit, result[i]);

            return result;
        }
    }
}