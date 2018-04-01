using Algorythms.Solution.LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.LeetCode
{
    [TestFixture]
    class LongestSubstringTest
    {
        [TestCase("abcav", 4)]
        [TestCase("abcavea", 5)]
        public void TestAlgorithm(string str, int length)
        {
            //Arrange

            //Act
            int actualLength = LongestSubstring.FindLongestSubstring(str);

            //Assert
            Assert.AreEqual(length, actualLength);
        }
    }
}
