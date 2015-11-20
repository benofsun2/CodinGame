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

namespace Codingame.Easy
{
    class SolutionE3
    {
        public static void MainFunction()
        {
            int road = int.Parse(Console.ReadLine()); // the length of the road before the gap.
            int gap = int.Parse(Console.ReadLine()); // the length of the gap.
            int platform = int.Parse(Console.ReadLine()); // the length of the landing platform.

            // game loop
            while (true)
            {
                int speed = int.Parse(Console.ReadLine()); // the motorbike's speed.
                int coordX = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");
                if (coordX <= road)
                {
                    if (speed <= gap)
                    {
                        Console.WriteLine("SPEED");
                    }
                    else if (speed > gap + 1)
                    {
                        Console.WriteLine("SLOW");
                    }
                    else
                    {
                        //Console.Error.WriteLine(road + " : " + coordX);
                        if (coordX != 0 && road % coordX < coordX)
                        {
                            Console.WriteLine("JUMP");
                        }
                        else
                        {
                            Console.WriteLine("WAIT");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("SLOW");
                }

                //Console.WriteLine("SPEED"); // A single line containing one of 4 keywords: SPEED, SLOW, JUMP, WAIT.
            }
        }
    }
}