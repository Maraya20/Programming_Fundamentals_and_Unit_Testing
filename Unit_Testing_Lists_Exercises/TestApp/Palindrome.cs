using System.Collections.Generic;
using System.Linq;

namespace TestApp;

public class Palindrome
{
    public static bool IsPalindrome(List<string> words)  // 121 112211 
    {
        return words
            .Select(s => s.ToLower())
            .All(word => word.SequenceEqual(word.Reverse()));
    }
}
