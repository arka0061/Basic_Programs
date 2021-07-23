using System;

public class Factors
{
        public static int number;
        public static float sum = 1;
        public static void factor()
        {
            int i;
            Factors obj = new Factors();
            Console.WriteLine("Welcome to Factors problem!");
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i<= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + number);
                }
            }
        }
    }

          