using System;

/// <summary>
/// class name
/// </summary>
class VectorMath
{
	/// <summary>
	/// method that calculates dot product of either two 2D or two 3D vectors.
	/// </summary>
	public static double DotProduct(double[] vector1, double[] vector2)
	{
		double[] oh_no = new double[2];
		if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3
		|| vector2.Length < 2 || vector2.Length > 3)
		{
			for (int i = 0; i < 2; i++)
				oh_no[i] = -1;
			return oh_no;
		}
		int len;
		if (vector1.Length == 2)
			len = 2;
		else
			len = 3;

		double[] good = new double[len];
		for (int i = 0; i < vector1.Length; i++)
			good[i] = (vector1[i] + vector2[i]);

		int dot = 0;
		for (int i = 0; i < good.Length; i++)
			dot += good[i];

		return dot;
	}
}
