using System.Numerics;

namespace ArraysOperations

{
    internal static class OneDimensionalArrays
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

        internal static bool TryGetDifOfMinMax(int[] incomingArray , out int dif) // trydo pattern
        {
            if (incomingArray == null || incomingArray.Length == 0)
            {
                dif = 0;
                return false;
            }
            dif =  incomingArray.Max() - incomingArray.Min();
            return true;
        }

        internal static bool IsArrayArranged(int[] incomingArray) //is it fine to name method like this?
        {
            if (incomingArray == null || incomingArray.Length == 0)
            {
                return true;
            }

            var length = incomingArray.Length;
            if (incomingArray[0] < incomingArray[^1])
            {
                for (int i = 1; i < length; i++)
                {
                    if (incomingArray[i - 1] > incomingArray[i])
                    {
                        return false;
                    }
                }
            }
            if (incomingArray[0] > incomingArray[^1])
            {
                for (int i = 1; i < length; i++)
                {
                    if (incomingArray[i - 1] < incomingArray[i])
                    {
                        return false;
                    }
                }
            }
            if (incomingArray[0] == incomingArray[^1])
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

        internal static void NullTheArrayElements(ref int[] incomingArray)
        {
            if (incomingArray == null || incomingArray.Length == 0)
            {
                return;
            }
            var minElementPosition = Array.IndexOf(incomingArray,incomingArray.Min());
            var maxElementPosition = Array.IndexOf(incomingArray, incomingArray.Max());

            var begin = Math.Min(minElementPosition, maxElementPosition);
            var end = Math.Max(minElementPosition, maxElementPosition);

            for (int i = begin+1; i < end; i++)
            {
                incomingArray[i] = 0; 
            }
            return;
        }

        internal static (int[] fibonacci, int mathSum , BigInteger mathProduct) GetFibonacciArray(uint length)
        {
            var fibonacci = new int[length];
            if (length == 0)
            {
                return (fibonacci,0,0);
            }
            fibonacci[0] = 1;
            if (length == 1)
            {
                return (fibonacci,1,1);
            }
            fibonacci[1] = 1;
            
            var mathSum = 0;
            BigInteger mathProduct = 1; //long instead of var because i need return long values to avoid possible overflow
            
            for (int i = 2; i < length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                mathSum += fibonacci[i];
                mathProduct *= fibonacci[i];
            }
            return (fibonacci, mathSum , mathProduct);
        }

        internal static int[] GetMergeArrays(int[] firstArray, int[] secondArray)
        {
            var answer = new List<int>();
            if (firstArray != null)
            {
                answer.AddRange(firstArray);
            }
            if (secondArray != null)
            {
                answer.AddRange(secondArray);
            }
            

            return answer.ToArray();
        }
    }
}
