using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson6
{
    class Triangle
    {
        public int Solution(int[] A)
        {
            int[] sortedA = A.OrderBy(a => a).ToArray();

            for(int i=0; i< sortedA.Length -2; i++)
            {
                if ((long)sortedA[i] + sortedA[i + 1] > sortedA[i + 2]) return 1;
            }

            return 0;
        }
    }
}
