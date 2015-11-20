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
    class SolutionE7
    {
        public static void MainFunction()
        {
            string MESSAGE = Console.ReadLine();

            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] bytes = ascii.GetBytes(MESSAGE);
            string strBinary = ByteToBinary(bytes);
            char[] chArray = strBinary.ToCharArray();
            int[] Aint = Array.ConvertAll(chArray, c => (int)Char.GetNumericValue(c));

            int set = Aint[0];
            string output = "";
            encodeSet(set, ref output);
            for (int i = 1; i < Aint.Length; i++)
            {
                if (Aint[i] == set)
                {
                    output += "0";
                }
                else
                {
                    set = Aint[i];
                    output += " ";
                    encodeSet(set, ref output);
                }

            }
            Console.WriteLine(output);
            Console.ReadKey();

        }

        static void encodeSet(int s, ref string output)
        {
            if (s == 0)
            {
                output += "00 0";
            }
            else
            {
                output += "0 0";
            }
        }

        static string ByteToBinary(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (byte c in data)
            {

                sb.Append(Convert.ToString(c, 2).PadLeft(7, '0'));
            }
            return sb.ToString();
        }
    }

}