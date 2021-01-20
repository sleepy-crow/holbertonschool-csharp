using System;

/// <summary>
/// class of the project
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method that adds two matrices and returns the resulting matrix
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (
            (matrix1.GetLength(0) != matrix1.GetLength(1)) ||
            (matrix2.GetLength(0) != matrix2.GetLength(1)) ||
            (matrix1.GetLength(0) != matrix2.GetLength(0)) ||
            (matrix1.GetLength(0) > 3) || (matrix1.GetLength(1) > 3)
            (matrix1.GetLength(0) < 2) || (matrix1.GetLength(1) < 2)
            (matrix2.GetLength(0) > 3) || (matrix2.GetLength(1) > 3)
            (matrix2.GetLength(0) < 2) || (matrix2.GetLength(1) < 2)
            )
            {
                double[,] oh_no = { {-1, -1}, {-1, -1} };
                return oh_no;
            }

            int len = matrix1.GetLength(0);
            double[,] mew = new double[len, len]
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    mew[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return mew;
    }
}
