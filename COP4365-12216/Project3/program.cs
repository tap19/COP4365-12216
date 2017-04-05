using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            BubbleSort bs = new BubbleSort();
            BubbleSort_02 bs2 = new BubbleSort_02();
            BubbleSort_03 bs3 = new BubbleSort_03();
            HelperClass hc = new HelperClass();
            int[] ints = new int[0];

            ints = hc.GetRandomInts(100, 1000);
            Console.WriteLine("----Example 18.5----");
            hc.PrintInts(ints, "int array");
            bs.sort(ints);
            hc.PrintInts(ints, "sorted int array");

            ints = hc.GetRandomInts(100, 1000);
            Console.WriteLine("\n----Example 18.6 a----");
            hc.PrintInts(ints, "int array");
            bs2.sort(ints);
            hc.PrintInts(ints, "sorted int array");

            ints = hc.GetRandomInts(100, 1000);
            Console.WriteLine("\n----Example 18.6 b----");
            hc.PrintInts(ints, "int array");
            bs3.sort(ints);
            hc.PrintInts(ints, "sorted int array");
        }
    }
}
