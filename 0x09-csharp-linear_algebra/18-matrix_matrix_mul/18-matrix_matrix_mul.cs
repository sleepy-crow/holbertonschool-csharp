using System;

/// <summary>
/// the class name
/// </summary>
class MatrixMath
{
	/// <summary>
	/// method that multiplies two matrices and returns the resulting matrix.
	/// </summary>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		double[,] oh_no = { { -1 } };
		if (matrix1.GetLength(1) != matrix2.GetLength(0))
		{
			return oh_no;
		}

        int len_rows = matrix1.GetLength(0);
        int len_cols = matrix2.GetLength(1);
        double[,] mew = new double[len_rows, len_cols];
        double mul = 0;
        for (int i = 0; i < len_rows; i++)
		{
			for (int j = 0; j < len_cols; j++)
			{
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    mul += matrix1[i, k] * matrix2[k, j];
                }
                mew[i, j] = mul;
			}
		}
        return mew;
	}
}
