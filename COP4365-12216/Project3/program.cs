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
            BubbleSort bs    = new BubbleSort();
            HelperClass hc   = new HelperClass();
            int[] ints       = hc.GetRandomInts(100,1000);

            Console.Write("int array        : ");
            hc.PrintInts(ints);
            Console.WriteLine();
            Console.WriteLine();

            bs.sort(ints);
            
            Console.Write("sorted int array : ");
                hc.PrintInts(ints);
                Console.WriteLine();
                Console.WriteLine();
        }
    }
}
