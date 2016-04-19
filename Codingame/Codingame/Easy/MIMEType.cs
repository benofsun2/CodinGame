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

namespace Codingame.Easy.MIMEType
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
            int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
            Dictionary<string, string> minesDict = new Dictionary<string, string>();
            for (int i = 0; i < N; i++)
            {
                //string[] inputs = { "html text/html", "png image/png", "test.html", "noextension", "portrait.png", "doc.TXT" };
                string[] inputs = Console.ReadLine().Split(' ');
                string EXT = inputs[0]; // file extension
                string MT = inputs[1]; // MIME type.
                minesDict.Add(EXT.ToLower(), MT);
            }
            for (int i = 0; i < Q; i++)
            {
                string FNAME = Console.ReadLine();
                string exten = FNAME.Substring(FNAME.LastIndexOf('.') + 1).ToLower();
                if (minesDict.ContainsKey(exten) && FNAME.Contains('.'))
                {
                    Console.WriteLine(minesDict[exten]);
                }
                else
                {
                    Console.WriteLine("UNKNOWN");
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            //Console.WriteLine("UNKNOWN"); // For each of the Q filenames, display on a line the corresponding MIME type. If there is no corresponding type, then display UNKNOWN.
        }
    }
}