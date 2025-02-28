using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp;

public class RepeatingChecker
{
    public static int FindFirstRepeatingElement(int[] nums) // nums 1, 2, 1, 1
    {
        HashSet<int> seenElements = new HashSet<int>(); // seenNumbers - empty

        foreach (int num in nums)
        {
            if (seenElements.Contains(num))
            {
                return num;
            }
            seenElements.Add(num);
        }

        return -1;
    }

    public static int FindLastRepeatingElement(int[] nums)
    {
        HashSet<int> seenElements = new HashSet<int>();
        int repeatingElement = -1;

        foreach (int num in nums)
        {
            if (seenElements.Contains(num))
            {
                repeatingElement = num;
            }
            seenElements.Add(num);
        }

        return repeatingElement;
    }
}
