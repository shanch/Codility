using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Lesson3
{
    public class FrogJmp
    {
        public int Solution(int X, int Y, int D)
        {
            return (Y - X + D - 1) / D;
        }

        /*public int Solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling((double)(Y - X) / (double)D);
        }*/

        /*public int Solution(int X, int Y, int D)
        {
            int count = 1;

            while(X + D * count < Y)
            {
                count++;
            }

            return count;
        }*/
    }
}
