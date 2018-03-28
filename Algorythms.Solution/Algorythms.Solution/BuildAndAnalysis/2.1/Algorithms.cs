using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms.Solution.BuildAndAnalysis._2._1
{
    public static class SomeAlgorithms
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

        public static byte[] AddBinaryNumbers(byte[] a, byte[] b)
        {
            int aLength = a.Length;
            int bLength = b.Length;

            if(aLength != bLength)
            {
                throw new Exception("You should provide arrays with equal length!");
            }

            int length = Math.Max(aLength, bLength);
            byte[] result = new byte[length + 1];

            byte reminder = 0;
            int index = length;
            while(index >= 1)
            {
                byte current = (byte)(a[index - 1] + b[index - 1] + reminder);
                if(current == 2)
                {
                    current = 0;
                    reminder = 1;
                }
                else if (current == 3)
                {
                    current = 1;
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }
                result[index] = current;
                index--;
            }
            if(reminder != 0)
            {
                result[0] = reminder;
            }
            return result;
        }
    }
}
