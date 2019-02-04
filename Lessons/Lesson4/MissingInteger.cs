using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson4
{
    public class MissingInteger
    {
        public int Solution(int[] A)
        {
            bool[] b = new bool[A.Length];

            for(int i=0; i<A.Length; i++)
            {
                if(A[i] < 1 || A.Length < A[i])
                {
                    continue;
                }

                b[A[i] - 1] = true;
            }

            for (int i=0; i<b.Length; i++)
            {
                if (!b[i]) return i + 1;
            }

            return A.Length + 1;
        }
    }
}
