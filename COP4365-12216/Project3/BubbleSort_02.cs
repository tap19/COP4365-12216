using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// implementation of Example 18.6 a using overridden BubbleSort.Sort() method
    /// </summary>
    class BubbleSort_02 : BubbleSort
    {
        public BubbleSort_02()
        {

        }
        /*
         * After the first pass, the largest number is guaranteed to be in the highest-numbered element 
         * of the array(for an array being sorted in ascending order); after the second pass,
         * the two highest numbers are “in place”; and so on.Instead of making nine comparisons
         * on every pass of a 10-element array, modify the bubble sort to make eight comparisons
         * on the second pass, seven on the third pass and so on.
         */
    }
}
