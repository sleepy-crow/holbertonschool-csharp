using System;


class Number
{
    public static int PrintLastDigit(int number)
    {
        int i;
        if (number > 0)
            i = number % 10;
        else
            i = (number % 10) * -1;

        Console.Write("{0:D}", i);
        return(i);
        
    }
}
