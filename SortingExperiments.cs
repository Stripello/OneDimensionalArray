using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ArraysOperations
{
    [MemoryDiagnoser]
    [RankColumn]
    public class SortingExperiments
    {
        private const int n = 10;
        private const int min = 0;
        private const int max = 100;
        private  int[] incomingArray;
        /*
        public SortingExperiments()
        {
            var random = new Random();
            incomingArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                incomingArray[i] = random.Next(min,max);
            }
        }
        */
        public SortingExperiments()
        {
            Random random = new Random();
            incomingArray = new int[n];
            for (int i =0; i< n; i++)
            {
                incomingArray[i] = random.Next(min,max);
            }
        }

        [Benchmark]
        public int[] BuildIn()
        {
            var answer = new int[incomingArray.Length];
            incomingArray.CopyTo(answer,0);
            Array.Sort(answer);
            return answer;
        }

        public int[] Bubble()
        {
            var answer = new int[incomingArray.Length];
            Array.Copy(incomingArray, answer, incomingArray.Length);
            for (int i = 0; i < answer.Length; i++)
            {
                for (int j = i; j < answer.Length; j++)
                {
                    if (answer[i] > answer[j])
                    {
                        (answer[i], answer[j]) = (answer[j], answer[i]);
                    }
                }
            }
            return answer;
        }

        [Benchmark]
        public int[] HalfingMethod()
        {
            var length = incomingArray.Length;
            var answer = new int[length];
            
            var firstLength = length / 2;
            var secondLength = length - firstLength;
            var firstSubarray = incomingArray[0..firstLength];
            var secondSubarray = incomingArray[firstLength..];
            Array.Sort(firstSubarray);
            Array.Sort(secondSubarray);
            var firstCounter = 0;
            var secondCounter = 0;
            
            for (int i = 0; i < length; i++)
            {
                if (firstCounter == firstLength)
                {
                    do
                    {
                        answer[i] = secondSubarray[secondCounter];
                        secondCounter++;
                        i++;

                    }
                    while (secondCounter < secondLength );
                    break;
                }
                if (secondCounter == secondLength)
                {
                    do
                    {
                        answer[i] = firstSubarray[firstCounter];
                        firstCounter++;
                        i++;
                    }
                    while (firstCounter < firstLength);
                    break;
                }

                if (firstSubarray[firstCounter] <= secondSubarray[secondCounter])
                {
                    answer[i] = firstSubarray[firstCounter];
                    firstCounter++;
                }
                 else
                 {
                     answer[i] = secondSubarray[secondCounter];
                     secondCounter++;
                 }
            }
            return answer;
            
        }
        
        public int[] HalfingStack()
        {
            var length = incomingArray.Length;
            var firstLength = incomingArray.Length / 2;
            var secondLength = length - firstLength;
            var firstSubarray = incomingArray[0..firstLength];
            var secondSubarray = incomingArray[firstLength..];
            Array.Sort(firstSubarray);
            Array.Sort(secondSubarray);

            var firstStack = new Stack<int>(firstSubarray);
            var secondStack = new Stack<int>(secondSubarray);

            var answer = new int[length];
            var tempOne = firstStack.Pop();
            var tempTwo = secondStack.Pop();
            for (int i = length-1; i > 0; i--)
            {
                if (tempOne >= tempTwo)
                {
                    answer[i] = tempOne;
                    firstLength--;
                    if (firstLength == 0)
                    {
                        i--;
                        answer[i] = tempTwo;
                        i--;
                        for (i = i; i >= 0; i--)
                        {
                            answer[i] = secondStack.Pop();
                        }
                        break;
                    }
                    tempOne = firstStack.Pop();
                }
                else
                {
                    answer[i] = tempTwo;
                    secondLength--;
                    if (secondLength == 0)
                    {
                        i--;
                        answer[i] = tempOne;
                        i--;
                        for (i = i; i >= 0; i--)
                        {
                            answer[i] = firstStack.Pop();
                        }
                        break;
                    }
                    tempTwo = secondStack.Pop();
                }
            }

            return answer;
        }
        
    }
}
