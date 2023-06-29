using System;
using System.Linq;
using System.Text;

namespace Task4
{
    public static class TextHelper
    {
        public static string ReverseString(string s)
        {
            var newS = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
                newS.Append(s[i]);

            return newS.ToString();
        }

        public static bool IsPalindrome(string s)
        {
            if (s.Equals(ReverseString(s)))
                return true;
            else
                return false;
        }
    }
}
