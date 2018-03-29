using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms.Solution
{
    public static class Helpers
    {
        public static void SwapElements<T>(this T[] arr, int indexA, int indexB)
        {
            int length = arr.Length;
            if(indexA >= length || indexB >= length || indexA < 0 || indexB < 0)
            {
                return;
            }
            T temp = arr[indexA];
            arr[indexA] = arr[indexB];
            arr[indexB] = temp;
        }
    }
}
