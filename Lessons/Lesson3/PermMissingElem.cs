using System.Collections.Generic;
using System.Linq;

namespace Lessons.Lesson3
{
    public class PermMissingElem
    {
        public int Solution(int[] A)
        {
            var occurrences = new HashSet<int>(Enumerable.Range(1, A.Length + 1));

            foreach (var a in A)
            {
                occurrences.Remove(a);
            }

            return occurrences.First();
        }
    }
}
