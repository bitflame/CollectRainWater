using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectRainWater
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static int Trap (int[] height)
        {
            int totalAmount = 0;
            if ( height == null || height.Length == 0)
            {
                return totalAmount;
            }
            int[] leftHeighest = new int[height.Length + 1];
            leftHeighest[0] = 0;
            for (int i = 0; i < height.Length; i++)
            {
                leftHeighest[i + 1] = Math.Max(leftHeighest[i], height[i]);

            }
            int rightHighest = 0;
            for (int i = height.Length-1;i>=0; i--)
            {
                rightHighest = Math.Max(height[i], rightHighest);
                totalAmount += Math.Min(leftHeighest[i], rightHighest) > height[i] ? Math.Min(leftHeighest[i], rightHighest)
                    - height[i] : 0;
            }
            return totalAmount;
        }
    }
}
