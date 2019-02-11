using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson9
{
    class MaxSliceSum
    {
        public int Solution(int[] A)
        {
            int maxHere = A[0];
            int maxSofar = A[0];

            for(int i=1; i<A.Length; i++)
            {
                maxHere = Math.Max(A[i], maxHere + A[i]);
                maxSofar = Math.Max(maxSofar, maxHere);
            }

            return maxSofar;
        }

        public int SlowSolution(int[] A)
        {
            int max = int.MinValue;

            for (int i = 0; i < A.Length - 1; i++)
            {
                int sum = A[i];

                if (sum > max) max = sum;

                for (int j = i + 1; j < A.Length; j++)
                {
                    sum += A[j];

                    if (sum > max) max = sum;
                }
            }

            return max;
        }
    }
}
