using NUnit.Framework;
using Algorithms;
using System;

namespace AlgorithmsTests
{
    class FibonachiTests
    {
        [TestCase(1, ExpectedResult = new int[] { 0 })]
        [TestCase(2, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(3, ExpectedResult = new int[] { 0, 1, 1 })]
        [TestCase(4, ExpectedResult = new int[] { 0, 1, 1, 2 })]
        [TestCase(5, ExpectedResult = new int[] { 0, 1, 1, 2, 3 })]
        [TestCase(6, ExpectedResult = new int[] { 0, 1, 1, 2, 3, 5 })]
        [TestCase(7, ExpectedResult = new int[] { 0, 1, 1, 2, 3, 5, 8 })]
        [TestCase(23, ExpectedResult = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89,
            144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711 })]
        public int[] Generate_Fib(int length)
        {
            return Fibonachi.GenerateFibonachi(length);
        }

        [TestCase(0)]
        public void Generate_Fib_NotValid(int length) => Assert.Throws<ArgumentException>(() => Fibonachi.GenerateFibonachi(length));
    }
}
