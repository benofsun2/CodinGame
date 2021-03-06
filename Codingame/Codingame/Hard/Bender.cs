﻿using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Codingame.Hard.Bender
{
    /**
     * Auto-generated code below aims at helping you parse
     * the standard input according to the problem statement.
     **/
    public class Solution
    {
        public static void Main(string[] args)
        {
            var sr = new StringReader(args[0]);
            Console.SetIn(sr);
            string[] inputs = Console.ReadLine().Split(' ');
            int L = int.Parse(inputs[0]);
            int C = int.Parse(inputs[1]);



            Map map = new Map(L, C);
            for (int i = 0; i < L; i++)
            {
                sr = new StringReader(args[i + 1]);
                Console.SetIn(sr);
                string row = Console.ReadLine();
                map.AddRow(i, row);
            }

            map.MemberScreenDump();

            MoveManager move = new MoveManager(ref map);
            List<string> returnval = new List<string>();
            int count = 1;
            do
            {


                returnval.Add(move.MoveBender(ref map));


                if (count > 200)
                {
                    move.FinishLine = true;
                    returnval = new List<string>();
                    returnval.Add("LOOP");
                }
                count++;
            } while (!move.FinishLine);
            //Console.Error.WriteLine(count);
            foreach (string s in returnval)
            {
                Console.WriteLine(s);
            }
        }







    }

    public class Map
    {
        private char[,] map;


        public Map(int L, int C)
        {
            map = new char[L, C];
            map.Initialize();

            t1X = t1Y = t2X = t2Y = 0;
        }

        public int startX { get; set; }
        public int startY { get; set; }
        public int endX { get; set; }
        public int endY { get; set; }

        public int t1X { get; set; }
        public int t1Y { get; set; }
        public int t2X { get; set; }
        public int t2Y { get; set; }

        public void MemberScreenDump()
        {

            Console.Error.WriteLine("startX: " + startX);
            Console.Error.WriteLine("startY: " + startY);
            Console.Error.WriteLine("endX: " + endX);
            Console.Error.WriteLine("endY: " + endY);
            Console.Error.WriteLine("t1X: " + t1X);
            Console.Error.WriteLine("t1Y: " + t1Y);
            Console.Error.WriteLine("t2X: " + t2X);
            Console.Error.WriteLine("t2Y: " + t2Y);
            //Console.WriteLine("" + );
        }

        public void AddRow(int i, string row)
        {
            //Console.Error.WriteLine(row);
            var chrar = row.ToCharArray();

            // Console.Error.WriteLine(chrar[0]);
            //*map[i,] = new char[chrar.Length];
            for (int j = 0; j < chrar.Length; j++)
            {
                map[i, j] = chrar[j];
                if (chrar[j] == '@')
                {
                    startY = i;
                    startX = j;

                }
                else if (chrar[j] == '$')
                {
                    endY = i;
                    endX = j;
                }
                else if (chrar[j] == 'T')
                {
                    if (t1X == 0 && t1Y == 0)
                    {
                        t1Y = i;
                        t1X = j;
                    }
                    else
                    {
                        t2Y = i;
                        t2X = j;
                    }

                }
            }
        }

        public void KillObsticleX(int x, int y)
        {
            map[y, x] = ' ';
        }

        public char GetNode(int x, int y)
        {
            // Console.Error.WriteLine("X, Y " + x + ", " + y);


            return map[y, x];
        }


        public char GetProjectedNode(int x, int y)
        {
            // Console.Error.WriteLine("X, Y " + x + ", " + y);
            if (map[y, x] == 'T')
            {
                if (x == t1X && y == t1Y)
                {
                    x = t2X;
                    y = t2Y;
                }
                else
                {
                    x = t1X;
                    y = t1Y;
                }
            }

            return map[y, x];
        }

    }

    public class MoveManager
    {
        //public bool FinishLine;

        public bool FinishLine;

        private string[] direction;

        private int GlobalDirectionChangeCounter = 0;
        private int GlobalDirectionReverseCounter = 3;
        private Dictionary<int, int> bounceReverse;
        private bool bounceIsReversed;
        private bool breakerIsOn;

        private bool killObsticle = false;

        public int currentX { get; set; }
        public int currentY { get; set; }
        public int currentD { get; set; }

        public int proposedX { get; set; }
        public int proposedY { get; set; }
        //public char proposedNode { get; set; }

        public MoveManager(ref Map map)
        {
            currentD = 0;

            direction = new string[4] { "SOUTH", "EAST", "NORTH", "WEST" };
            FinishLine = false;
            SetToggleBounce(true);
            SetBreakerMode(true);
            currentX = map.startX;
            currentY = map.startY;

        }


        public int GlobalDirectionChangeCounterCheck
        {
            get
            {
                if (bounceIsReversed)
                    return GlobalDirectionReverseCounter;
                else
                    return GlobalDirectionChangeCounter;
            }

            set
            {
                //GlobalDirectionChangeCounter = value;
                if (bounceIsReversed)
                    GlobalDirectionReverseCounter = (value == -1) ? 3 : value - 1;
                else
                    GlobalDirectionChangeCounter = (value == 4) ? 0 : value + 1;
            }

        }


        public char NodePeek(ref Map map)
        {
            proposedY = currentY;
            proposedX = currentX;
            switch (currentD)
            {
                case 2:
                    proposedY = currentY - 1;
                    //if (proposedY < 0)
                    //    proposedY = 0;
                    break;
                case 0:
                    proposedY = currentY + 1;
                    break;
                case 1:
                    proposedX = currentX + 1;
                    break;
                case 3:
                    proposedX = currentX - 1;
                    //if (proposedX < 0)
                    //    proposedX = 0;
                    break;
            }
            var proposedNode = map.GetProjectedNode(proposedX, proposedY);


            if (proposedNode == '#' || proposedNode == 'X')
            {
                //BlockedDirectionChange(proposedNode);
                if (BlockedDirectionChange(proposedNode))
                {
                    map.KillObsticleX(proposedX, proposedY);
                }
                else
                {
                    proposedNode = NodePeek(ref map);
                }
            }
            GlobalDirectionChangeCounter = 0;
            GlobalDirectionReverseCounter = 3;
            return proposedNode;

        }

        public bool BlockedDirectionChange(char pnode)
        {
            if ((!breakerIsOn && pnode == 'X') || pnode == '#')
            {
                currentD = GlobalDirectionChangeCounterCheck;
                GlobalDirectionChangeCounterCheck = GlobalDirectionChangeCounterCheck;

            }
            else
            {
                return true;
            }
            return false;
        }

        public string MoveBender(ref Map map)
        {

            var pnode = NodePeek(ref map);

            var holder = currentD;

            currentX = proposedX;
            currentY = proposedY;


            switch (pnode)
            {
                case '@':

                    break;
                case '$':
                    FinishLine = true;
                    break;
                case 'S':
                    currentD = 0;
                    break;
                case 'E':
                    currentD = 1;
                    break;
                case 'N':
                    currentD = 2;
                    break;
                case 'W':
                    currentD = 3;
                    break;
                case 'B':
                    SetBreakerMode(breakerIsOn);
                    break;
                case 'I':
                    SetToggleBounce(bounceIsReversed);
                    break;
                case 'T':

                    if (proposedX == map.t1X && proposedY == map.t1Y)
                    {
                        proposedX = map.t2X;
                        proposedY = map.t2Y;
                    }
                    else
                    {
                        proposedX = map.t1X;
                        proposedY = map.t1Y;
                    }

                    break;



            }

            currentX = proposedX;
            currentY = proposedY;
            //mover.CurrentDirection = currentD;

            //if (map.GetNode(currentX, currentY) == '$')
            //    return "FINISHED";  

            return direction[holder];

        }

        private void SetToggleBounce(bool isInit)
        {
            bounceIsReversed = (!isInit);
        }

        private void SetBreakerMode(bool isInit)
        {
            breakerIsOn = !isInit;
        }
    }
}