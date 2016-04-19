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
namespace Codingame.Easy.ASCIIArt
{ 
class Solution
{
    public static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        Dictionary<string, string[]> letters = new Dictionary<string, string[]>();
        string alfa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0";

        for (int l = 0; l < alfa.Length; l++)
        {
            letters.Add(alfa.Substring(l, 1), new string[H]);
        }

        string answer = "";
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            int pos = 0;
            while (ROW.Length > 0)
            {
                string lt = alfa.Substring(pos, 1);
                letters[lt][i] = ROW.Substring(0, L);
                ROW = ROW.Substring(L);
                pos++;
            }
            for (int x = 0; x < T.Length; x++)
            {
                string lt = T.Substring(x, 1).ToUpper();
                if (letters.ContainsKey(lt))
                {
                    answer += letters[lt][i].ToString();
                }
                else
                {
                    answer += letters["0"][i].ToString();
                }
            }
            answer += Environment.NewLine;
        }

        Console.WriteLine(answer);
    }
}

}