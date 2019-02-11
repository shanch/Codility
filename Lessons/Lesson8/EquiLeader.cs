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
            int leader = GetLeader(A);

            if(leader == int.MinValue) return 0;

            int totalCntOfLeader = A.Where(n => n == leader).Count();

            int cntOfLeader = 0;

            int cnt = 0;
            for(int i=0; i<A.Length; i++)
            {
                if (A[i] == leader) cntOfLeader++;

                if ((cntOfLeader >= (i + 1) / 2 + 1) && ((totalCntOfLeader - cntOfLeader) >= (A.Length - i - 1) / 2 + 1))
                {
                    cnt++;
                }
            }

            return cnt;
        }

        private int GetLeader(int[] aa)
        {
            aa = aa.OrderBy(a => a).ToArray();

            int possibleLeader = aa[aa.Length / 2];

            int cnt = 0;

            foreach(int a in aa)
            {
                if (a == possibleLeader) cnt++;
            }

            if(cnt > aa.Length / 2)
            {
                return possibleLeader;
            }

            return int.MinValue;
        }
    }
}
