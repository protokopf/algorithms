using Algorythms.Solution.BuildAndAnalysis._2._1;
using System;

namespace Algorythms.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1 Insertion sort
            int[] initialArray = new int[] { 9, 5, 10, 3, 7, 6, 2, 1, 4, 8 };
            initialArray.InsertionSort((a, b) => a < b);
            PrintArray(initialArray);

            Console.Read();
        }

        private static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("Printing array!");
            int length = array.Length;
            for(int i = 0; i < length; ++i)
            {
                Console.WriteLine($"--[{i}] = {array[i]}");
            }
            Console.WriteLine("Finished printing array!");
        }
    }
}
