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
namespace Codingame.Medium
{
    class SolutionM1
    {
        public static void MainFunction()
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]); // the total number of nodes in the level, including the gateways
            int L = int.Parse(inputs[1]); // the number of links
            int E = int.Parse(inputs[2]); // the number of exit gateways

            var list = new List<Tuple<int, int>>();
            var killList = new List<Tuple<int, int>>();
            for (int i = 0; i < L; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int N1 = int.Parse(inputs[0]); // N1 and N2 defines a link between these nodes
                int N2 = int.Parse(inputs[1]);

                list.Add(Tuple.Create(N1, N2));

            }

            for (int i = 0; i < E; i++)
            {
                int EI = int.Parse(Console.ReadLine());
                killList.AddRange(list.Where(p => p.Item1 == EI || p.Item2 == EI));
                //Console.WriteLine(killList.Count);
            }
            var listA = new List<int>(killList.Count);
            var listB = new List<int>(killList.Count);
            foreach (var t in killList)
            {
                listA.Add(t.Item1);
                listB.Add(t.Item2);
            }

            // game loop
            while (true)
            {
                int SI = int.Parse(Console.ReadLine()); // The index of the node on which the Skynet agent is positioned this turn
                var closestA = listA.Aggregate((x, y) => Math.Abs(x - SI) < Math.Abs(y - SI) ? x : y);
                var closestB = listB.Aggregate((x, y) => Math.Abs(x - SI) < Math.Abs(y - SI) ? x : y);
                var actual = (Math.Abs(closestA - SI) < Math.Abs(closestB - SI) ? closestA : closestB);
                var kill2 = killList.FirstOrDefault(p => p.Item1 == actual || p.Item2 == actual);
                if (kill2 == null)
                    kill2 = killList.FirstOrDefault(p => p.Item1 == closestA && p.Item2 == closestB);

                Console.WriteLine(kill2.Item1 + " " + kill2.Item2);

            }
        }
    }
}

