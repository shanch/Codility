using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson8
{
    class EquiLeader
    {
        public int Solution(int[] A)
        {
            int cnt = 0;

            for(int i=0; i<A.Length; i++)
            {
                int leader1 = GetLeader(A.Take(i + 1).ToArray());
                int leader2 = GetLeader(A.Skip(i + 1).ToArray());

                if (leader1 == leader2) cnt++;
            }

            return cnt;
        }

        private int GetLeader(int[] aa)
        {
            aa = aa.OrderBy(a => a).ToArray();

            int lenOfLeader = aa.Length / 2 + 1;

            for(int i=0; i<aa.Length - lenOfLeader + 1; i++)
            {
                if (aa[i] == aa[i + lenOfLeader - 1]) return aa[i];
            }

            return -1;
        }
    }
}
