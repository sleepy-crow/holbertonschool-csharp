using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        if (number > 0)
            Console.WriteLine($"{number:D} is positive");
        else if (number < 0)
            Console.WriteLine($"{number:D} is negative");
        else
            Console.WriteLine($"{number:D} is zero");
    }
}
