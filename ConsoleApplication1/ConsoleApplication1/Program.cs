using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static double distance(int x1, int y1, int x2, int y2)
        {
            //double dX = x1 - x2;
            //double dY = y1 - x2;
            //double multi = dX * dX + dY * dY;
            //double rad = Math.Round(Math.Sqrt(multi), 3);
            //Dist = Mod (x1 - x2) + Mod (y1 - y2)

            return (Math.Abs(x1 - x2) + Math.Abs(y1 - y2));
        }

        private static double distance2(int x1, int y1, int x2, int y2)
        {
            double dX = x1 - x2;
            double dY = y1 - y2;
            double multi = dX * dX + dY * dY;
            double rad = Math.Round(Math.Sqrt(multi), 3);
            //Dist = Mod (x1 - x2) + Mod (y1 - y2)

            return rad;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(distance(0, 0, 16000, 8000));
            Console.WriteLine(distance(0, 0, 14500, 8000));
            Console.WriteLine(distance(0, 0, 14100, 8000));

            Console.WriteLine(distance(0, 0, 16000, 8000));
            Console.WriteLine(distance(0, 0, 16000, 6500));
            Console.WriteLine(distance(0, 0, 16000, 6000));



            Console.WriteLine(distance2(0, 0, 16000, 8000));
            Console.WriteLine(distance2(0, 0, 14500, 8000));
            Console.WriteLine(distance2(0, 0, 14100, 8000));

            Console.WriteLine(distance2(0, 0, 16000, 8000));
            Console.WriteLine(distance2(0, 0, 16000, 6500));
            Console.WriteLine(distance2(0, 0, 16000, 6000));

            Console.ReadKey();

            //14500
            //var[2]: 8000
            //var[3]: 14100
            //var[4]: 8000
        }
    }
}
