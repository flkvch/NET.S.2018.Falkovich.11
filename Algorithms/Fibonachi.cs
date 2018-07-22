using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static int[] GenerateFibonachi(int sequenceLength)
        {
            if (sequenceLength < 1)
            {
                throw new ArgumentException("Sequence Length should be bigger than 0!");
            }

            int[] array = new int[sequenceLength];
            FibonachiRecursive(sequenceLength, ref array);
            return array;
        }

        private static int FibonachiRecursive(int sequenceLength, ref int[] array)
        {
            if (sequenceLength == 1)
            {
                array[0] = 0;
                return 0;
            }

            if (sequenceLength == 2)
            {
                array[0] = 0;
                array[1] = 1;
                return 1;
            }
            else
            {
                return array[sequenceLength - 1] = FibonachiRecursive(sequenceLength - 1, ref array)
                    + FibonachiRecursive(sequenceLength - 2, ref array);
            }
        }
    }
}
