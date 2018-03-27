using Algorythms.Solution.BuildAndAnalysis._2._1;
using Algorythms.Solution.LeetCode;
using System;

namespace Algorythms.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1 Insertion sort

            //int[] initialArray = new int[] { 9, 5, 10, 3, 7, 6, 2, 1, 4, 8 };
            //initialArray.InsertionSort((a, b) => a < b);
            //PrintArray(initialArray);

            //LeetCode AddTwoNumbers problem
            ListNode l1 = Helpers.CreateNodeFromArray(new[] { 2, 4, 3 });
            ListNode l2 = Helpers.CreateNodeFromArray(new[] { 5, 6, 4 });
            ListNode answer = NodeSolution.AddTwoNumbers(l1, l2);

            ListNode l11 = Helpers.CreateNodeFromArray(new[] { 0 });
            ListNode l22 = Helpers.CreateNodeFromArray(new[] { 0 });
            ListNode answer2 = NodeSolution.AddTwoNumbers(l11, l22);

            ListNode l111 = Helpers.CreateNodeFromArray(new[] { 9 });
            ListNode l222 = Helpers.CreateNodeFromArray(new[] {1,9,9,9,9,9,9,9,9,9});
            ListNode answer22 = NodeSolution.AddTwoNumbers(l111, l222);


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
