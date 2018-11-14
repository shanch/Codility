using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson3
{
    public class TapeEquilibrium
    {
        public int Solution(int[] A)
        {
            int sumOfFirstPart = A[0];
            int sumOfSecondPart = A.Skip(1).Sum();

            int min = Math.Abs(sumOfFirstPart - sumOfSecondPart);

            for (int p = 1; p < A.Length - 1; p++)
            {
                sumOfFirstPart += A[p];
                sumOfSecondPart -= A[p];

                int diff = Math.Abs(sumOfFirstPart - sumOfSecondPart);

                if (diff < min)
                {
                    min = diff;
                }
            }

            return min;
        }

        public int SolutionVer1(int[] A)
        {
            int min = int.MaxValue;

            for (int p = 1; p < A.Length - 1; p++)
            {
                int sumOfFirstPart = A.Take(p).Sum();
                int sumOfSecondPart = A.Skip(p).Sum();

                int diff = Math.Abs(sumOfFirstPart - sumOfSecondPart);

                if (diff < min)
                {
                    min = diff;
                }
            }

            return min;
        }

        public int SolutionVer2(int[] A)
        {
            int sumOfFirstPart = A[0];
            int sumOfSecondPart = A.Skip(1).Sum();

            int min = int.MaxValue;

            int diff = Math.Abs(sumOfFirstPart - sumOfSecondPart);

            for (int p = 1; p < A.Length - 1; p++)
            {
                diff = Math.Abs(diff - A[p] * 2);

                if (diff < min)
                {
                    min = diff;
                }
            }

            return min;
        }
    }
}
