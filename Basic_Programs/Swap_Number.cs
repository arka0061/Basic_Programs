using System;
public class Swap_Number
{
    public static void swap()
    {
        int number1 = 5, number2 = 10;
        Console.WriteLine("Before swap number1= " + number1 + " number2= " + number2);
        number1 = number1 * number2;     
        number2 = number1 / number2;       
        number1 = number1/ number2;   
        Console.Write("After swap number1= " + number1+ " number2= " + number2);
    }
}