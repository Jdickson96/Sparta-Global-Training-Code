using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowApp
{
    public static class LoopTypes
    {
        internal static int HighestForEachLoop(List<int> nums)
        {
            int highestNo = nums[0];
            foreach(int i in nums)
            {
                if (i > highestNo)
                {
                    highestNo = i;
                }
            }
            return highestNo;
        }

        internal static int HighestForLoop(List<int> nums)
        {
            int highestNo = nums[0];
            if (nums.Count > 1)
            {
                for (int i = 1; i < nums.Count; i++)
                {
                    if (nums[i] > highestNo)
                    {
                        highestNo = nums[i];
                    }
                }
            }
            return highestNo;
        }

        internal static int HighestWhileLoop(List<int> nums)
        {
            int highestNo = nums[0];
            int iterator = 0;
            if (nums.Count > 1)
            {
                while (iterator < nums.Count)
                {
                    if (nums[iterator] > highestNo)
                    {
                        highestNo = nums[iterator];
                    }

                    iterator++;
                }
            }
            return highestNo;
        }

        internal static int HighestDoWhileLoop(List<int> nums)
        {
            int highestNo = int.MinValue;
            int iterator = 0;
            if (nums.Count > 1)
            {
                do
                {
                    if (nums[iterator] > highestNo)
                    {
                        highestNo = nums[iterator];
                    }

                    iterator++;
                } while (iterator < nums.Count);
            }
            return highestNo;
        }
    }
}
