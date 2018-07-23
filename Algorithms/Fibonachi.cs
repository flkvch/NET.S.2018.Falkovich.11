using System;
using System.Collections.Generic;
using System.Numerics;

namespace Algorithms
{
    /// <summary>
    /// Generates Fibonachi sequence
    /// </summary>
    public static class Fibonachi
    {
        /// <summary>
        /// Generates the fibonachi.
        /// </summary>
        /// <param name="sequenceLength">Length of the sequence.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Sequence Length should be bigger than 0!</exception>
        public static IEnumerable<BigInteger> GenerateFibonachi(int sequenceLength)
        {
            if (sequenceLength < 1)
            {
                throw new ArgumentException("Sequence Length should be bigger than 0!");
            }

            return FibonachiCore(sequenceLength);
        }

        private static IEnumerable<BigInteger> FibonachiCore(int sequenceLength)
        {
            BigInteger bprev = 0;
            BigInteger prev = 1;

            for (int i = 0; i < sequenceLength; ++i)
            {
                yield return bprev;
                var temp = prev;
                prev += bprev;
                bprev = temp;
            }
        }
    }
}
