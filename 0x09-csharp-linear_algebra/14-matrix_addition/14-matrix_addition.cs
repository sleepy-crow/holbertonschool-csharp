using System;

/// <summary>
/// class of the project
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method that adds two matrices and returns the resulting matrix
    /// </summary>
    /// <param name="matrix1"> the firts matrix </param>
    /// <param name="matrix2"> the second matrix </param>
    /// <returns> a new matrix that is the result of the addition of the matrix 1 and 2 </returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
            (matrix1.GetLength(0) != matrix1.GetLength(1)) ||
            (matrix2.GetLength(0) != matrix2.GetLength(1)) ||
            (matrix1.GetLength(0) != matrix2.GetLength(0)) ||
            (matrix1.GetLength(1) != matrix2.GetLength(1)) ||
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
