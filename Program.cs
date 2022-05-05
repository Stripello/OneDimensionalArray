using System.Collections;
using System;
using ArrayOperation;

var first  = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }};

var second = new int[,] { { 1, 2, 3 }, { 0, 0, 0 },{ 1,2,3} };

var answer = TwoDimensionalArraysAndMatrix.TryGetSummOfMatrix(first, second, out int[,] sumMatrix);
Console.WriteLine(1);