using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeComplexity3
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution s = new Solution();
    //        Console.WriteLine(s.solution(10, 85, 30));

    //        Console.WriteLine(s.solution(1, 5, 2));
    //    }


    //}

    class Solution
    {
        public int solution(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int count = 0;

            count = (int)Math.Floor((double)((Y - X) / D));

            count += ((Y - X) % D == 0) ? 0 : 1;

            return count;
        }
    }



}