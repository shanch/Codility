using System;
using System.Linq;

namespace Lessons.Lesson6
{
    class MaxProductOfThree
    {
        public int Solution(int[] A)
        {
            int[] sortedA = A.OrderBy( a => a ).ToArray();

            return Math.Max(sortedA[0] * sortedA[1] * sortedA[sortedA.Length -1], sortedA[sortedA.Length - 3] * sortedA[sortedA.Length - 2] * sortedA[sortedA.Length - 1]);
        }

        public int BadSolution(int[] A)
        {
            int answer = int.MinValue;

            for (int p = 0; p < A.Length - 2; p++)
            {
                for (int q = p + 1; q < A.Length - 1; q++)
                {
                    for (int r = p + 2; r < A.Length; r++)
                    {
                        int product = A[p] * A[q] * A[r];

                        if (product > answer) answer = product;
                    }
                }
            }

            return answer;
        }
    }
}
