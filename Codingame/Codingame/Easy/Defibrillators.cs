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

    class SolutionE9
    {
        public static void MainFunction()
        {
            string LON = Console.ReadLine();
            string LAT = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            double dLon = double.Parse(LON.Replace(',', '.'));
            double dLat = double.Parse(LAT.Replace(',', '.'));
            // int N = 3;

            Console.Error.WriteLine(dLat);
            List<Site> sites = new List<Site>();

            for (int i = 0; i < N; i++)
            {
                string DEFIB = Console.ReadLine();
                Console.Error.WriteLine(DEFIB);
                var list = DEFIB.Split(';');
                Site site = new Site();
                site.Id = int.Parse(list[0]);
                site.Name = list[1];
                site.Address = list[2];
                site.Phone = list[3];
                site.LON = double.Parse(list[4].Replace(',', '.'));
                site.LAT = double.Parse(list[5].Replace(',', '.'));

                double x = ((site.LON - dLon) * Math.Cos((dLat + site.LAT) / 2));
                double y = (site.LAT - dLat);
                site.Distance = Math.Sqrt(x * x + y * y) * 6371;
                Console.Error.WriteLine(site.Distance + " " + site.Name);
                sites.Add(site);

            }

            var mindist = sites.Min(p => p.Distance);
            var obj = sites.Where(p => p.Distance == mindist).FirstOrDefault();


            Console.WriteLine(obj.Name);
        }


        public struct Site
        {
            public int Id;
            public string Name;
            public string Address;
            public string Phone;
            public double LON;
            public double LAT;
            public double Distance;
        }
    }
}