using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Example20_10
    {
        Object obj1;
        Object obj2;
        /// <summary>
        /// default constructor
        /// </summary>
        public Example20_10()
        {

        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="obj1">first object</param>
        /// <param name="obj2">second object</param>
        public Example20_10(Object obj1, Object obj2)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
        }
        /// <summary>
        /// compares two objects to determine equality
        /// </summary>
        /// <returns>true if both objects are equal</returns>
        public bool IsEqualTo()
        {
            return false;
        }
        /// <summary>
        /// override for parameter input rather than object property input
        /// </summary>
        /// <param name="inputString">input string for base method</param>
        /// <returns>see base method</returns>
        public bool IsEqualTo(Object obj1, Object obj2)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
            return IsEqualTo();
        }
    }
}
