using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var program = new Program();
            //Console.WriteLine(StacksQueues.Brackets.Solution.solution("{[()()]}"));
            //Console.WriteLine(StacksQueues.Brackets.Solution.solution("([)()]"));
            //var value = new StringBuilder();
            //for (var count = 0; count < 10000; count++)
            //    value.Append("()");
            //value.Append(")(");
            //value.Append("()");

            //Console.WriteLine(StacksQueues.Brackets.Solution.solution(value.ToString()));
            int[] A = 
            A[0] = 5
  A[1] = 5
  A[2] = 1
  A[3] = 7
  A[4] = 2
  A[5] = 3
  A[6] = 5

            //int[] a = new int[] {3,4,4,6,1,4,4};


            //Solution s = new Solution();

            //Disks.Solution s = new Disks.Solution();

            //var res = s.solution(GetBigArray(1, 2147483647, 20000));

            //StacksQueues.Brackets.Solution s = new StacksQueues.Brackets.Solution();
            //s.solution("{[()()]}");

            //s.solution("{[()()}");


            //s.solution("{[(stufff)(qeqwe)]}");

            //a = new int[] { 2 };
            //res = s.solution(1, a);

            //a = new int[] { 1 };
            //res = s.solution(1, a);
            //Console.WriteLine(s.solution());

            Test1.Solution s = new Test1.Solution();
            var ret = s.solution();

            Console.ReadKey();
        }


        public static int[] GetBigArray(int min, int max, int count)
        {
            int[] ret = new int[count];
            ret.Initialize();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                ret[i] = rnd.Next(min, max);
            }
            return ret;
        }


    }



}