//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] a = new int[] { 3, 1, 2, 4, 3 };

//            Console.WriteLine(solution2(a));

//            int[] b = new int[] { -1000, 1000 };

//            Console.WriteLine(solution2(b));

//            int[] c = new int[] { -3, -1, -2, -4, -3 };

//            Console.WriteLine(solution2(c));
//        }





//        public static int solution(int[] A)
//        {
//            // write your code in C99
//            int lowest = 1000;

//            int i = 0;
//            for (int idx = 1; idx < A.Length; idx++)
//            {
//                int low = 0;
//                int high = 0;
//                i = idx - 1;
//                for (int j = idx; j < A.Length; j++)
//                {
//                    high += A[j];
//                    if (i >= 0)
//                        low += A[i];
//                    i--;
//                }

//                if (lowest > Math.Abs(high - low))
//                    lowest = Math.Abs(high - low);

//            }

//            return lowest;

//        }


//        public int solution3(int[] A)
//        {
//            // write your code in C# 6.0 with .NET 4.5 (Mono)
//            int totalSum = 0;
//            int firstSum = A[0];
//            for (int i = 1; i < A.Length; i++)
//                totalSum += A[i];

//            int min = Math.Abs(firstSum - totalSum);

//            for (int i = 1; i < A.Length - 1; i++)
//            {
//                firstSum += A[i];
//                totalSum -= A[i];
//                if (Math.Abs(firstSum - totalSum) < min)
//                    min = Math.Abs(firstSum - totalSum);

//            }
//            return min;

//        }

//        public static int solution2(int[] A)
//        {
//            // write your code in C99
//            int lowest = 1000;
//            if (A.Length > 2)
//            {
//                for (int idx = 0; idx < A.Length; idx++)
//                {
//                    // check and set vars
//                    //int[] first;
//                    //int[] second;
//                    if (idx > 0)
//                    {
//                        //Split(A, idx, out first, out second);
//                        // process values
//                        //var val = Math.Abs(first.Sum() - second.Sum());
//                        var val = Math.Abs(A.Take(idx).Sum() - A.Skip(idx).Sum());
//                        lowest = (val < lowest) ? val : lowest;
//                    }
//                }
//            }
//            else
//            {
//                lowest = Math.Abs(A[0] - A[1]);

//            }

//            return lowest;

//        }

//        public static void Split<T>(T[] array, int index, out T[] first, out T[] second)
//        {
//            first = array.Take(index).ToArray();
//            second = array.Skip(index).ToArray();
//        }


//    }



//}