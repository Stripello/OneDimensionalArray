using System.Collections;
using System;
using ArrayOperation;

var first  = new int[,] { { 1 , 2 , 3 }, 
                          { 14, 0 , 5 } };

var second = new int[,] { { 1, 5 }, 
                          { 2, 10 }, 
                          { 3,15} };

var answer = TwoDimensionalArraysAndMatrix.TryMultiplyMatrix(first, second, out int[,] sumMatrix);

var random = new Random();
for (int i = 0; i < 10000; i++)
{
    Console.Write(random.Next(10000)+"," );
}
