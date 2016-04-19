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
namespace Codingame.Medium.APUInitPhase
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
            int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis

            Console.Error.WriteLine("width: " + width);
            Console.Error.WriteLine("height: " + height);
            var list = new List<Tuple<int, int>>();
            char[][] grid = new char[height][];

            for (int i = 0; i < height; i++)
            {
                string line = Console.ReadLine(); // width characters, each either 0 or .

                grid[i] = line.ToArray();
                Console.Error.WriteLine("line: " + line);
            }

            for (int i = 0; i < grid.Length; i++)
            {

                for (int j = 0; j < grid[0].Length; j++)
                {
                    Console.Error.WriteLine(i + "  : " + j);

                    Console.Error.WriteLine(grid[i][j]);
                    if (grid[i][j] == '0')
                    {
                        list.Add(Tuple.Create(j, i));
                        var x = j + 1;
                        bool yesx = false;
                        while (x < width && yesx == false)
                        {
                            if (grid[i][x] == '0')
                            {
                                list.Add(Tuple.Create(x, i));
                                yesx = true;
                            }
                            x++;
                        }
                        if (!yesx)
                        {
                            list.Add(Tuple.Create(-1, -1));
                        }



                        var y = i + 1;
                        bool yesy = false;
                        while (y < height && yesy == false)
                        {
                            if (grid[y][j] == '0')
                            {
                                list.Add(Tuple.Create(j, y));
                                yesy = true;
                            }
                            y++;
                        }
                        if (!yesy)
                        {
                            list.Add(Tuple.Create(-1, -1));
                        }
                    }
                }
            }

            string output = "";
            for (int count = 1; count <= list.Count; count++)
            {
                output = output + list[count - 1].Item1 + " " + list[count - 1].Item2 + " ";

                Console.Error.WriteLine(output);
                if (count % 3 == 0)
                {
                    Console.WriteLine(output);
                    output = "";
                }
            }


            
        }
    }
}

