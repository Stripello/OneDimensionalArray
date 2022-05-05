using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArray
{
    internal class SortingExperiments
    {
        internal static void BuildIn(ref int[] incomingArray)
        {
            Array.Sort(incomingArray);
        }

        internal static void BubbleSimple(ref int[] incomingArray)
        {
            for (int i = 1; i < incomingArray.Length; i++)
            {
                for (int j = i; j < incomingArray.Length; j++)
                {
                    if (incomingArray[i] > incomingArray[j])
                    {
                        (incomingArray[i], incomingArray[j]) = (incomingArray[j], incomingArray[i]);
                    }
                }
            }
        }
    }
}
