using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace Codingame.Medium.HeatDetector
{
    public class Player
    {
        private static bool local = false;

        public static void Main(string[] args)
        {
            if(local)
            {
                var sr = new StringReader(args[0]);
                Console.SetIn(sr);
            }
           
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int W = int.Parse(inputs[0]); // width of the building.
            int H = int.Parse(inputs[1]); // height of the building.
            if (local)
            {
                var sr = new StringReader(args[1]);
                Console.SetIn(sr);
            }
            int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
            if (local)
            {
                var sr = new StringReader(args[2]);
                Console.SetIn(sr);
            }
            inputs = Console.ReadLine().Split(' ');
            int X0 = int.Parse(inputs[0]);
            int Y0 = int.Parse(inputs[1]);
            Console.Error.WriteLine("W: " + W);
            Console.Error.WriteLine("H: " + H);
            Console.Error.WriteLine("N: " + N);
            Console.Error.WriteLine("X0: " + X0);
            Console.Error.WriteLine("Y0: " + Y0);
            Mover m = new Mover(W, H);
            string output;
            // game loop
            int i = 3;
            while (true)
            {
                if (local)
                {
                    var sr = new StringReader(args[i]);
                    Console.SetIn(sr);
                }
                string BOMBDIR = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
                Console.Error.WriteLine("BOMBDIR: " + BOMBDIR);
                output = m.Move(X0,Y0,BOMBDIR);
                X0 = m.CurrentX;
                Y0 = m.CurrentY;
                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");

                Console.WriteLine(output); // the location of the next window Batman should jump to.
                i++;
            }
        }
    }

    public class Mover
    {
        int _w;
        int _h;


        public Mover(int w, int h)
        {
            topx = _w = w;
            topy = _h = h;
            lowx = 0;
            lowy = 0;
        }

        public int lowx { get; set; }
        public int lowy { get; set; }
        public int topx { get; set; }
        public int topy { get; set; }
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }

        public string Move(int x, int y, string hint)
        {
            int nx = 0;
            int ny = 0;
            if(hint.Contains('U'))
            {
                topy = y;
                ny = (lowy / 2);
            }
            else if(hint.Contains('D'))
            {
                lowy = y;
                ny = (y + (topy - y) / 2);
            }

            if (hint.Contains('R'))
            {
                lowx = x;
                nx = (x + (topx - x) / 2);
            }
            else if (hint.Contains('L'))
            {
                topx = x;
                nx = (lowx / 2);
            }
            CurrentX = nx;
            CurrentY = ny;
            return nx + " " + ny;
        }

        public string Move2(int x, int y, string hint)
        {
            int jump = 2;
            int nx = x;
            int ny = y;
            if (hint.Contains('U'))
            {
                ny = (Math.Abs(y - jump));
            }
            else if (hint.Contains('D'))
            {
                ny = (y + jump); //Math.Abs((_h - y) / 2));
            }

            if (hint.Contains('R'))
            {
                nx = (x + jump);//Math.Abs((_w - x) / 2));
            }
            else if (hint.Contains('L'))
            {
                nx = (Math.Abs(x - jump));
            }
            CurrentX = nx;
            CurrentY = ny;
            return nx + " " + ny;
        }

    }
}
