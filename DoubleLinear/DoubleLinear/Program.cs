using System;
using System.Collections;
using System.Collections.Generic;

namespace DoubleLinear
{
    public static class DoubleLinear
    {
        private static ISet<int> nums;
        private static ISet<int> seen;

        public static int dblLinear(int n, IList<int> numList)
        {
            nums = new SortedSet<int>();
            seen = new HashSet<int>();
            nums.Add(1);
            for (int i = 0; i < n; i++)
            {
                generateNumbers();
            }

            return numList[n];
        }

        public static void generateNumbers()
        {
            foreach (int x in new SortedSet<int>(nums))
            {
                if (seen.Contains(x))
                {
                    continue;
                }
                if (nums.Count >= 250000)
                {
                    break;
                }
                int y = (2 * x) + 1, z = (3 * x) + 1;
                if (y > 0)
                {
                    nums.Add(y);
                }
                if (z > 0)
                {
                    nums.Add(z);
                }
                seen.Add(x);
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
