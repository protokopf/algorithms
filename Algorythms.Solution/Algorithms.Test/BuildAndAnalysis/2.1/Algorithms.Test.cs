using Algorithms.Test.Helpers;
using Algorythms.Solution.BuildAndAnalysis._2._1;
using NUnit.Framework;

namespace Algorithms.Test.BuildAndAnalysis._2._1
{
    [TestFixture]
    public class AlgorithmsTest
    {
        [TestCase(
               new byte[] { 0, 1, 1 }, 
               new byte[] { 0, 1, 1 }, 
            new byte[] { 0, 1, 1, 0 }
        )]
        [TestCase(
               new byte[] { 0, 0, 1, 0, 0, 1 },
               new byte[] { 0, 1, 0, 1, 1, 0 },
            new byte[] { 0, 0, 1, 1, 1, 1, 1 }
        )]
        [TestCase(
               new byte[] { 0, 0, 0, 0, 0, 1 },
               new byte[] { 0, 0, 0, 0, 0, 0 },
            new byte[] { 0, 0, 0, 0, 0, 0, 1 }
        )]
        [TestCase(
               new byte[] { 1, 1, 1, 1, 1, 1 },
               new byte[] { 0, 0, 0, 0, 0, 1 },
            new byte[] { 1, 0, 0, 0, 0, 0, 0 }
        )]
        [TestCase(
               new byte[] { 1, 1, 1 },
               new byte[] { 0, 1, 1 },
            new byte[] { 1, 0, 1, 0 }
        )]
        public void AddBinaryNumbers(byte[]a, byte[]b, byte[] expectedResult)
        {
            //Arrange

            //Act
            byte[] result = SomeAlgorithms.AddBinaryNumbers(a, b);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsEqualTo(expectedResult, (f, s) => f == s));
        }
    }
}
