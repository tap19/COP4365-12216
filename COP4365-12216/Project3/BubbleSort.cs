using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class BubbleSort
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public BubbleSort()
        {

        }
        /// <summary>
        /// algorithm from https://www.tutorialspoint.com/data_structures_algorithms/bubble_sort_algorithm.htm
        /// </summary>
        /// <param name="ints">an array of integers to be sorted</param>
        public void sort(int[] ints)
        {
            int sentinel = ints.Length;
            bool swapped = false;
            int temp = 0;

            for (int i = 0; i < sentinel-1; i++)
            {
                swapped = false;
                for (int j = 0; j < sentinel-1; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
