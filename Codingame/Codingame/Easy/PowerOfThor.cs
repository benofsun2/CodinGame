using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/

namespace Codingame.Easy.PowerOfThor
{
    class Solution
    {
        public static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int lightX = int.Parse(inputs[0]); // the X position of the light of power
            int lightY = int.Parse(inputs[1]); // the Y position of the light of power
            int initialTX = int.Parse(inputs[2]); // Thor's starting X position
            int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

            // game loop
            while (true)
            {
                int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");
                //Console.WriteLine(lightX);
                //Console.WriteLine(lightY); // A single line providing the move to be made: N NE E SE S SW W or NW
                //Console.Error.WriteLine(X + " : " + Y);
                if (lightX > initialTX)
                {
                    if (lightY == initialTY)
                    {
                        Console.WriteLine("E");
                        initialTX += 1;
                    }
                    else if (lightY > initialTY)
                    {
                        Console.WriteLine("SE");
                        initialTX += 1;
                        initialTY += 1;
                    }
                    else
                    {
                        Console.WriteLine("NE");
                        initialTX += 1;
                        initialTY -= 1;
                    }
                }
                else if (lightX < initialTX)
                {
                    if (lightY == initialTY)
                    {
                        Console.WriteLine("W");
                        initialTX -= 1;

                    }
                    else if (lightY > initialTY)
                    {
                        Console.WriteLine("SW");
                        initialTX -= 1;
                        initialTY += 1;
                    }
                    else
                    {
                        Console.WriteLine("NW");
                        initialTX -= 1;
                        initialTY -= 1;
                    }
                }
                else
                {
                    if (lightY > initialTY)
                    {
                        Console.WriteLine("S");
                        initialTY += 1;
                    }
                    else
                    {
                        Console.WriteLine("N");
                        initialTY -= 1;
                    }
                }
            }
        }
    }
}