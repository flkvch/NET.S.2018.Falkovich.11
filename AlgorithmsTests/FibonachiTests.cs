using NUnit.Framework;
using Algorithms;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AlgorithmsTests
{
    class FibonachiTests
    {
        [Test]
        public void Generate_Fib()
        {
            BigInteger[][] expected = 
                {
                new BigInteger[] { 0 },
                new BigInteger[] { 0, 1 },
                new BigInteger[] { 0, 1, 1 },
                new BigInteger[] { 0, 1, 1, 2 },
                new BigInteger[] { 0, 1, 1, 2, 3 },
                new BigInteger[] { 0, 1, 1, 2, 3, 5 },
                new BigInteger[] { 0, 1, 1, 2, 3, 5, 8 },
                new BigInteger[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89,
                    144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711 }
                };
            int[] inputLengthes = new int[] { 1, 2, 3, 4, 5, 6, 7, 23 };
        
            for (int i = 0; i < inputLengthes.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], Fibonachi.GenerateFibonachi(inputLengthes[i]));
            }
        }

        [TestCase(0)]
        public void Generate_Fib_NotValid(int length) => Assert.Throws<ArgumentException>(() => Fibonachi.GenerateFibonachi(length));
    }
}
