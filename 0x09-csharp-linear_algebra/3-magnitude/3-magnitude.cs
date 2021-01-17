using System;

    /// <summary> This is the class object <summary>
    class VectorMath
    {
        /// <summary> >This method gets either a 2D or 3D vector and returns its magnitude,
        ///if the vector is not 2D or 3D it returns -1<summary>
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
