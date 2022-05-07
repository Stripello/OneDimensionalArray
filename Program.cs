using System.Collections;
using System;
using ArraysOperations;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;


//BenchmarkRunner.Run<SortingExperiments>();

var exp = new SortingExperiments();

var sort1 = exp.BuildIn();

foreach (var item in sort1)
{
    Console.Write(item + " ");
}
Console.WriteLine();
var sort2 = exp.HalfingStack();
foreach (var item in sort2)
{
    Console.Write(item + " ");
}
