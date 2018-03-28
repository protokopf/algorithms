using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.Helpers
{
    public static class ArrayHelpers
    {
        public static bool IsEqualTo<T>(this T[] a, T[] b, Func<T,T, bool> comparer)
        {
            int aLength = a.Length;
            int bLength = b.Length;
            if(aLength != bLength)
            {
                return false;
            }
            for(int i = 0; i < aLength; ++i)
            {
                if(!comparer(a[i],b[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
