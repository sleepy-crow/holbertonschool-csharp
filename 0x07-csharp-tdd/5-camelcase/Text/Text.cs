using System;

namespace Text
{
    /// <summary>This is the classic string class, or is it?.</summary>
    public class Str
    {
        /// <summary>This method counts the number of letters on a string using
        /// the camelCase format.</summary>
        public static int CamelCase(string s)
        {
            int count = 0;

            if (s == null || s.Length == 0)
                return 0;

            foreach (var item in s)
            {
                if (Char.IsUpper(item))
                {
                    count++;
                }
            }

            return count + 1;
        }
    }
}
