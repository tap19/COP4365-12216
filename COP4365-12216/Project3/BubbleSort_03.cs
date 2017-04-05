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
    class BubbleSort_03 : BubbleSort
    {
        public BubbleSort_03()
        {

        }
        /*
         *The data in the array may already be in the proper order or near-proper order, so why
         * make nine passes of a 10-element array if fewer will suffice? Modify the sort to check at
         * the end of each pass whether any swaps have been made.If none have been made, the
         * data must already be in the proper order, so the app should terminate.If swaps have
         * been made, at least one more pass is needed.
         */
    }
}
