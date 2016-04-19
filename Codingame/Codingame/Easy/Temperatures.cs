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
namespace Codingame.Easy.Temperatures
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
            string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            if (n != 0)
            {
                var newArray = Array.ConvertAll(temps.Split(' ').ToArray(), int.Parse);
                var nearest = newArray.OrderBy(x => Math.Abs((long)x - 0)).First();
                Console.WriteLine((newArray.Contains(Math.Abs(nearest))) ? Math.Abs(nearest) : nearest);
            }
            else
                Console.WriteLine(0);

        }
    }
}