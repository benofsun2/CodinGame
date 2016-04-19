using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
namespace Codingame.Easy.HorseRacingDuals
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] intArr = new int[N];

            for (int i = 0; i < N; i++)
            {
                int pi = int.Parse(Console.ReadLine());
                intArr[i] = pi;

            }
            Array.Sort(intArr);

            int min = intArr[N - 1];

            for (int i = 0; i < intArr.Length; i++)
            {
                if (i < intArr.Length - 1 && min > Math.Abs(intArr[i] - intArr[i + 1]))
                {
                    min = Math.Abs(intArr[i] - intArr[i + 1]);
                }
            }

            Console.WriteLine(min);
        }
    }
}