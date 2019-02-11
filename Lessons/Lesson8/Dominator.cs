using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson8
{
    class Dominator
    {
        public int Solution(int[] A)
        {
            if (A.Length == 0) return -1;

            int[] sortedA = A.OrderBy(n => n).ToArray();

            int possibleDominator = sortedA[A.Length / 2];

            int cnt = 0;
            int result = 0;

            for(int i=0; i<A.Length; i++)
            {
                if(A[i] == possibleDominator)
                {
                    cnt++;
                    result = i;
                }
            }

            if(cnt > A.Length / 2)
            {
                return result;
            }

            return -1;
        }
    }
}
