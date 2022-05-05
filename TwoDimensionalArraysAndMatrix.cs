using System.Numerics;

namespace ArrayOperation
    
{
    internal static class TwoDimensionalArraysAndMatrix
    {
        internal static bool TryGetSummOfMatrix(int [,] firstMatrix, int[,] secondMatrix, out int[,]? summMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                summMatrix = null;
                return false;
            }
            (int columns, int rows) dimensions = (firstMatrix.GetLength(1), firstMatrix.GetLength(0));
            if (dimensions != (secondMatrix.GetLength(1), secondMatrix.GetLength(0)) )
            {
                summMatrix = null;
                return false;
            }
            summMatrix = new int[dimensions.rows, dimensions.columns];
            for (int i = 0; i < dimensions.rows; i++)
            {
                for (int j = 0; j < dimensions.columns; j++)
                {
                    summMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i,j];
                }
            }
            return true;
        }

        internal static bool TryMultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, out int[,]? productionMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                productionMatrix = null;
                return false;
            }

            var firstRows = firstMatrix.GetLength (0);
            var firstColumns = firstMatrix.GetLength (1);

            var secondRows = secondMatrix.GetLength (0);
            var secondColumns = secondMatrix.GetLength (1);

            if (  )
            {
                productionMatrix = null;
                return false;
            }

            productionMatrix = new int[dimensions.rows, dimensions.columns];
            for (int i = 0; i < dimensions.rows; i++)
            {
                for (int j = 0; j < dimensions.columns; j++)
                {
                    productionMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }
            return true;
        }

    }
}
