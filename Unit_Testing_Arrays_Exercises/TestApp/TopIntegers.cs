using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp;

public class TopIntegers
{
    public string FindTopIntegers(int[] nums)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < nums.Length; i++) // 1, 2, 3
        {
            bool topInt = true;
            for (int j = i + 1; j < nums.Length; j++) // 2, 3
            {
                if (nums[i] <= nums[j]) // 1 <= 2
                {
                    topInt = false;
                    break; // break for 1, 2
                }
            }
            if (topInt)
                sb.Append(nums[i] + " "); // adding 3
        }

        return sb.ToString().TrimEnd();
    }
}
