using System;
using System.Collections.Generic;

    /// <summary>This is the class Obj.</summary>
    class Obj
    {
        /// <sumary>
        /// method that returns True if the object is an int, otherwise return False.
        /// </sumary>
        public static bool IsOfTypeInt(object obj)
        {
            if (obj.GetType() == typeof(int))
                return true;
            return false;
        }
    }
