using System.Collections;
using System;
using ArrayOperation;

var first  = new int[] { };
first = null;
var second = new[] { 0, 0, 0 };


 foreach (var element in OneDimensionalArrays.MergeTwoArrays(first, second))
{
    Console.WriteLine(element);

}

