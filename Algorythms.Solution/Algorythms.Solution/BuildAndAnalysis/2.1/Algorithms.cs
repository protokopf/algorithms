using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms.Solution.BuildAndAnalysis._2._1
{
    public static class Algorithms
    {
        public static void InsertionSort<T>(this T[] array, Func<T,T, bool> comparer)
        {
            int length = array.Length;
            for(int i = 0; i < length; ++i)
            {
                T currentValue = array[i];
                int j = i - 1;
                while(j >= 0 && comparer(currentValue, array[j]))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = currentValue;
            }
        }
    }
}
