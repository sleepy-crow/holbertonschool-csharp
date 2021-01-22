using System;

/// <summary>
/// Class name
/// </summary>
class MatrixMath
{
	/// <summary>
	/// 
	/// </summary>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		double[,] oh_no = { {-1} };
		if (
			(matrix.GetLength(0) != matrix.GetLength(1)) ||
			(matrix.GetLength(0) > 3) || (matrix.GetLength(1) > 3) ||
			(matrix.GetLength(0) < 2) || (matrix.GetLength(1) < 2)
			)
		{
			return oh_no;
		}

		int len = matrix.GetLength(0);
		double[,] mew = new double[len, len];
		for (int i = 0; i < len; i++)
		{
			for (int j = 0; j < len; j++)
			{
				mew[i, j] = matrix[i, j] * scalar;
			}
		}
		return mew;
	}
}
