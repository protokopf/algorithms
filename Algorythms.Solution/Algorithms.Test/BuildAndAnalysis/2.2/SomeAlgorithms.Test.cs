using Algorithms.Test.Helpers;
using Algorythms.Solution.BuildAndAnalysis._2._2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.BuildAndAnalysis._2._2
{
    [TestFixture]
    public class SomeAlgorithms
    {
        [TestCase(new int[] { 4,3,1,10,23,8,7 })]
        public void TestSort(int[] arr)
        {
            //Arrange
            int[] expected = arr.ToArray();
            Array.Sort(expected);

            //Act
            arr.SelectionSort((a, b) => a > b);

            //Assert
            Assert.IsTrue(arr.IsEqualTo(expected, (a,b) => a == b));
        }
    }
}
