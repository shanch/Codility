using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson4
{
    public class MaxCounters
    {
        public int[] Solution(int N, int[] A)
        {
            var counters = new int[N];

            var max = 0;
            var baseline = 0;

            foreach(int a in A)
            {
                if(a >= 1 && a <= N)
                {
                    if(counters[a - 1] < baseline)
                    {
                        counters[a - 1] = baseline + 1;
                    }
                    else
                    {
                        counters[a - 1]++;
                    }

                    if (counters[a - 1] > max)
                    {
                        max = counters[a - 1];
                    }
                }
                else if(a == N + 1)
                {
                    baseline = max;
                }
            }

            for(int i=0; i<N; i++)
            {
                if(counters[i] < baseline)
                {
                    counters[i] = baseline;
                }
            }

            return counters;
        }

        public int[] SolutionSlow(int N, int[] A)
        {
            var counters = new int[N];

            var max = 0;

            foreach (int a in A)
            {
                if (a >= 1 && a <= N)
                {
                    // increase
                    counters[a - 1]++;

                    if (counters[a - 1] > max)
                    {
                        max = counters[a - 1];
                    }
                }
                else if (a == N + 1)
                {
                    // max counter
                    for (int i = 0; i < N; i++)
                    {
                        counters[i] = max;
                    }
                }
            }

            return counters;
        }
    }
}
