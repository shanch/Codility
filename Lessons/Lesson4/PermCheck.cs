using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson4
{
    public class PermCheck
    {
        public int Solution(int[] A)
        {
            var B = new bool[A.Length];

            foreach(var a in A)
            {
                if (a > A.Length) return 0;

                if (B[a - 1]) return 0;

                B[a - 1] = true;
            }

            if(B.Any(b => !b))
            {
                return 0;
            }

            return 1;
        }
    }
}
