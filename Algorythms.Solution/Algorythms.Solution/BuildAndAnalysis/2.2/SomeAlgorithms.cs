using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms.Solution.BuildAndAnalysis._2._2
{
    public static class SomeAlgorithms
    {
        public static void SelectionSort<T>(this T[] arr, Func<T,T,Boolean> comparer)
        {
            int length = arr.Length;
            for(int i = 0; i < length - 1; ++i)
            {
                int minIndex = i;
                for(int j = i; j < length; ++j)
                {
                    if(comparer(arr[minIndex], arr[j]))
                    {
                        minIndex = j;
                    }
                }
                arr.SwapElements(minIndex, i);
            }
        }
    }
}
