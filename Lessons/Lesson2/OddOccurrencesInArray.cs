using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson2
{
    public class OddOccurrencesInArray
    {
        public int Solution(int[] A)
        {
            var occurrences = new HashSet<int>();

            foreach(var num in A)
            {
                if (occurrences.Contains(num))
                {
                    occurrences.Remove(num);
                }
                else
                {
                    occurrences.Add(num);
                }
            }

            return occurrences.Take(1).First();
        }
    }
}
