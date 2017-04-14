using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Example19_4
    {
        String inputString = "";
        /// <summary>
        /// default constructor
        /// </summary>
        public Example19_4()
        {
            
        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="inputString">defines inputString for ReverseString method</param>
        public Example19_4(String inputString)
        {
            this.inputString = inputString;
        }
        /// <summary>
        /// requests user input a new inputString
        /// </summary>
        public void RequestString()
        {
            this.inputString = Console.ReadLine();
        }
        /// <summary>
        /// reads input string as defined by parameterized constructor, override of this method, or RequestString method
        /// </summary>
        /// <returns>input string in reverse</returns>
        public String ReverseString()
        {
            return this.inputString;
        }
        /// <summary>
        /// override for parameter input rather than object property input
        /// </summary>
        /// <param name="inputString">input string for base ReverseString method</param>
        /// <returns>see base method</returns>
        public String ReverseString(String inputString)
        {
            this.inputString = inputString;
            return ReverseString();
        }
    }
}
