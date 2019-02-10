using System.Collections.Generic;

namespace Lessons.Lesson6
{
    class Distinct
    {
        public int Solution(int[] A)
        {
            HashSet<int> hs = new HashSet<int>(A);

            return hs.Count;
        }
    }
}
