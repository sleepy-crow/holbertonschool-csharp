using System;

    /// <summary>
    /// 
    /// </summary>
    class VectorMath
    {
        /// <summary>
        /// 
        /// </summary>
        public static double[] Multiply(double[] vector, double scalar)
        {
            double[] oh_no = new double[2];
            if (vector.Length < 2 || vector.Length > 3)
            {
                for (int i = 0; i < 2; i++)
                oh_no[i] = -1;
            return oh_no;
            }
            int len = 0;
            if (vector.Length == 2)
                len = 2;
            else
                len = 3;

            double[] mew = new double[len];
            for (int i = 0; i < vector1.Length; i++)
                mew[i] = (vector1[i] + vector2[i]);
            return mew;
        }
    }
