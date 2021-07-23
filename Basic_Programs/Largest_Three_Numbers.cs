using System;

public class Largest_Three_Numbers
{
    public static void check()
    {
        int num1, num2, num3;
        Console.Write("Input the 1st number :");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the  2nd number :");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd  number :");
        num3 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2 && num1 > num3)
        {
            Console.Write(num1+" " +"is the greatest among three.");
        }
        if (num2 > num1 && num2 > num3)
        {
            Console.Write(num2 + " " + "is the greatest among three.");

        }
        else

            Console.Write("num3" +" "+ " is the greatest among three");
    }
}