using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson4
{
    public class FrogRiverOne
    {
        public int Solution(int X, int[] A)
        {
            HashSet<int> hs = new HashSet<int>(Enumerable.Range(1, X));

            for(int i=0; i<A.Length; i++)
            {
                hs.Remove(A[i]);

                if (hs.Count == 0) return i; 
            }

            return -1;

        }
    }
}
