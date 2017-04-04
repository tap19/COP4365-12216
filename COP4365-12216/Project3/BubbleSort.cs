using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class BubbleSort
    {
        private int[] intArray = new int[0];
        /// <summary>
        /// default BubbleSort constructor
        /// </summary>
        public BubbleSort(int[] intArray)
        {
            this.intArray = intArray;
        }
        /// <summary>
        /// sorts the intArray property
        /// </summary>
        /// <returns></returns>
        public int[] sort()
        {
            return intArray;
        }
    }
}
