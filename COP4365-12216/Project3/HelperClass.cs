using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class HelperClass
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public HelperClass()
        {

        }
        /// <summary>
        /// returns an integer array of given length with random values
        /// </summary>
        /// <returns>an integer array of given length with random values</returns>
        public int[] GetRandomInts(int intsLength, int maxValue)
        {
            Random random = new Random();
            int[] ints = new int[intsLength];
            int itemValue = 0;
            for (int i = 0; i < intsLength; i++)
            {
                itemValue = random.Next(maxValue);
                ints[i] = itemValue;
            }
            return ints;
        }
        public void PrintInts(int[] ints)
        {
            for(int i=0;i<ints.Length;i++)
            {
                Console.Write(ints[i]);
                if (i != ints.Length - 1)
                    Console.Write(',');
            }
        }
    }
}
