using System;
using System.Collections.Generic;

    /// <summary>This is the class Obj.</summary>
    class Obj
    {
        /// <sumary>
        /// method that returns True if the object is an instance of, or if the object is an instance
        /// of a class that inherited from, Array, otherwise return False.
        /// </sumary>
        public static bool IsInstanceOfArray(object obj)
        {
            if (obj is Array)
                return true;
            return false;
        }
    }
