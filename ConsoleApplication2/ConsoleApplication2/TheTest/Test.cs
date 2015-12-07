using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Solution
    {
        public int[] solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            //In base −2, a 1 at position i means (−2)i.

            //So, a [1,1] in positions [i,i+1] means (−2)i + (−2)i+1 = (−2)i + (−2)(−2)i = (1 + −2)(−2)i = −(−2)i.

            //So you can negate any occurrence of a [1,0] by changing it to a [1,1], and vice versa.

            //Any other occurrences of 0, of course, can be left intact: −0 = 0.

            //So in your example, we split [1,0,0,1,1] into [{1,0}, {0}, {1,1}], negate each part to get [{1,1}, {0}, {1,0}], i.e., [1,1,0,1,0], and remove the unnecessary high 0, producing [1,1,0,1].
        }
    }
}
