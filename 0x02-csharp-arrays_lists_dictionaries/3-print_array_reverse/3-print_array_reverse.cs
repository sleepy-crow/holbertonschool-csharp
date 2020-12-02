using System;


class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null)
		{
			for (int size = array.Length - 1; size >= 0; size--)
			{
				Console.Write(array[size]);
				if (size != 0)
				{
					Console.Write(" ");
				}
			}
		}
		Console.WriteLine("");
    }
}
