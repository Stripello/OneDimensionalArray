namespace OneDimensionalArray
{
    internal static class ArrayOperation
    {
        internal static (int[] even, int[] odd) GetOddAndEvenSubarrays(int[] incomingArray)
        {
            var evenList = new List<int>();
            var oddList = new List<int>();
            foreach (var element in incomingArray)
            {
                var temp = element % 2;
                if (temp == 0)
                {
                    evenList.Add(element);
                    continue;
                }
                if (temp == 1 || temp == -1)
                {
                    oddList.Add(element);
                    continue;
                }
                else
                {
                    throw new ArgumentException("Wrong incoming array.");
                }
            }
            evenList.Sort();
            oddList.Sort();
            return (evenList.ToArray(), oddList.ToArray());
        }

        internal static int GetDifOfMinMax(int[] incomingArray)
        {
            return incomingArray.Max() - incomingArray.Min();
        }

        internal static bool IsArrayArranged(int[] incomingArray)
        {
            var length = incomingArray.Length;
            if (incomingArray[0] < incomingArray[^0])
            {
                for (int i = 1; i < length; i++)
                {
                    if (incomingArray[i - 1] > incomingArray[i])
                    {
                        return false;
                    }
                }
            }
            if (incomingArray[0] > incomingArray[^0])
            {
                for (int i = 1; i < length; i++)
                {
                    if (incomingArray[i - 1] < incomingArray[i])
                    {
                        return false;
                    }
                }
            }
            if (incomingArray[0] == incomingArray[^0])
            {
                for (int i = 1; i < length; i++)
                {
                    if (incomingArray[i - 1] != incomingArray[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
