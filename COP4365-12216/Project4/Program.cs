using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputString = "This is a string!";
            Example19_4 e194 = new Example19_4();
            Example19_5 e195 = new Example19_5();
            Example20_10 e210 = new Example20_10();

            Console.WriteLine("----Example 19.4----");
            Console.WriteLine( e194.ReverseString(inputString) );
            Console.WriteLine();

            Console.WriteLine("----Example 19.5----");
            Console.WriteLine(e195.IsPalindrome() );
            Console.WriteLine();
            
            Console.WriteLine("----Example 20.10----");
            Console.WriteLine( e210.IsEqualTo() );
            Console.WriteLine();
        }
    }
}
