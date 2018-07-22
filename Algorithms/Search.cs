using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Binary Search
    /// </summary>
    public static class Search
    {
        /// <summary>
        /// Binary Search
        /// </summary>
        /// <typeparam name="T">Type of array</typeparam>
        /// <param name="a">Array for searching</param>
        /// <param name="element">The element, which will be found.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns>
        /// Position of element in array. If there is no such element returns -1.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// a
        /// or
        /// element
        /// </exception>
        /// <exception cref="ArgumentException">Element is out of range! - element</exception>
        public static int BinarySearch<T>(T[] a, T element, IComparer<T> comparer)
        {
            if (a == null) 
            {
                throw new ArgumentNullException($"{nameof(a)} can't be null.");
            }

            if (element == null) 
            {
                throw new ArgumentNullException($"{nameof(element)} can't be null.");
            }

            if (a.Length == 0) 
            {
                return -1;
            }

            if ((comparer.Compare(element, a[0]) < 0) || (comparer.Compare(element, a[a.Length - 1]) > 0)) 
            {
                throw new ArgumentException("Element is out of range!", nameof(element));
            }

            int first = 0;
            int last = a.Length;

            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (comparer.Compare(element, a[mid]) <= 0)
                {
                    last = mid;
                }
                else
                {
                    first = mid + 1;
                }
            }

            if (comparer.Compare(a[last], element) == 0)
            {
                return last;
            }
            else
            {
                return -1;
            }
        }
    }
}