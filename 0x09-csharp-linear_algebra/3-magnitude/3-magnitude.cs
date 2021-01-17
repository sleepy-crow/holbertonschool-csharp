using System;

namespace _3_magnitude
{
    /// <summary> <summary>
    class VectorMath
    {
        /// <summary> <summary>
        public static double Magnitude(double[] vector)
        {
            if (vector.Length < 2 || vector.Length > 3)
                return -1;
            
            double r = 0;

            foreach (double i in vector)
            {
                r += (i * i);
            }
            r = Math.Round(Math.Sqrt(r), 2);
            return r;
        }
    }
}
