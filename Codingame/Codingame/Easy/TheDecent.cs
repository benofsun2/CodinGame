﻿using System;
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
    class SolutionE2
    {
        public static void MainFunction()
        {

            // game loop
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int spaceX = int.Parse(inputs[0]);
                int spaceY = int.Parse(inputs[1]);
                int holder = 0;
                for (int i = 0; i < 8; i++)
                {

                    int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
                    if (mountainH > holder)
                    {
                        holder = i;
                    }
                    //Console.Error.WriteLine(mountainH + "/n");
                }
                if (spaceX == holder)
                {
                    Console.WriteLine("FIRE");
                }
                else
                {
                    Console.WriteLine("HOLD"); // either:  FIRE (ship is firing its phase cannons) or HOLD (ship is not firing).    
                }
                // Write an action using Console.WriteLine()
                //Console.Error.WriteLine("Debug messages...");


            }
        }
    }
}