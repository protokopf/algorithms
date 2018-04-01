using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms.Solution.LeetCode
{
    public static class LongestSubstring
    {
        public static int FindLongestSubstring(string s)
        {
            int length = s.Length;
            int max = 0;
            for (int i = 0; i < length; ++i)
            {
                if (length - i < max)
                {
                    break;
                }
                HashSet<char> hash = new HashSet<char>();
                for (int j = i; j < length; ++j)
                {
                    if (!hash.Add(s[j]))
                    {
                        break;
                    }
                }
                int hashCount = hash.Count;
                max = max > hashCount ? max : hashCount;
            }
            return max;
        }
    }
}
