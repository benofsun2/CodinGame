using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Codingame.Hard.SuperComputer
{
    /**
     * Auto-generated code below aims at helping you parse
     * the standard input according to the problem statement.*
     **/
    public class Solution
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(args[0]);
            SortedList<int,Task> tasks = new SortedList<int,Task>();
            for (int i = 1; i <= count; i++)
            {
                string[] inputs = args[i].Split(' ');
                int J = int.Parse(inputs[0]);
                int D = int.Parse(inputs[1]);
                Console.WriteLine(J + ":" + D);

                tasks.Add(D, new Task(J, D));
            }
            var list = tasks.Reverse().ToList();



            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("answer");

        }



    }

    public class Task
    {
        public Task(int start,int duration)
        {
            Start = start;
            Duration = duration;
            End = start + duration;
        }

        int Start { get; set; }
        int Duration { get; set; }
        int End { get; set; }
    }

    
}