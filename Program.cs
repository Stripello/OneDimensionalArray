using System.Collections;
using System;

var intArray = new int[] { 1, 2, 3, 4, 5, -12,7,0 };
Array.Sort(intArray);
foreach (var element in intArray)
{
    Console.WriteLine(element);
}
