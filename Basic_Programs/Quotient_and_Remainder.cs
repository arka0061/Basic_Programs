using System;

public class Quotient_and_Remainder
{
    public static void  Quotient_and_Remainders()
    {
        int i;
        int divisor;
        int divident;
        double remainder = 0.0;
        double quotient = 0.0;
        Quotient_and_Remainder obj = new Quotient_and_Remainder();
        Console.WriteLine("Welcome to Quotient And Remainder Problem!");
        Console.WriteLine("Enter divisor");
        divisor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter dividend");
        divident = Convert.ToInt32(Console.ReadLine());
        quotient = divisor% divident;
        remainder = divisor/divident ;
        Console.WriteLine("Quotient is :" + quotient);
        Console.WriteLine("Remainder is " + remainder);
    }

    }
 