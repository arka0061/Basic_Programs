using System;

public class Even_odd
{
    public static void check()
    {
        int i;
        Console.Write("Enter a Number : ");
        i = Convert.ToInt32(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.Write("Entered Number is an Even Number");
            Console.Read();
        }
        else
        {
            Console.Write("Entered Number is an Odd Number");
            Console.Read();
        }
    }
}
    
