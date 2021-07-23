using System;

namespace Basic_Programs
{
    class Harmonic_Number
    {
        public static int number;
        public static float sum = 1;
       public static void harmonic()
        {
            Harmonic_Number obj = new Harmonic_Number();
            Console.WriteLine("Welcome to harmonic number problem!");
            Console.WriteLine("Enter a number grater than 0");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Please Enter correct input");
            }
            else
            {
                obj.logic();
            }
        }
        void logic()
        {
            int i;
            Console.Write("1");
            for (i = 1; i <= number; i++)
            {
                sum = sum + (float)(1 / i);
                Console.Write(" " + "+" + "1/" + i);
            }
            Console.WriteLine();
            Console.WriteLine("Nth number is : " + sum);
        }

    }
}