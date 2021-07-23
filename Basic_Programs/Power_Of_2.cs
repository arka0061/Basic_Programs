using System;

namespace Basic_Programs
{
    class Power_Of_2
    {
        public static int N;
        public static void power()
        {
            Power_Of_2 obj = new Power_Of_2();
            Console.WriteLine("Welcome to Power Of 2 problem!");
            Console.WriteLine("Please Enter a Number grater than 0");
            N = Convert.ToInt32(Console.ReadLine());
            if (N != 0)
            {
                obj.logic();
            }
            else
            {
                Console.WriteLine("Please Enter Correct Input");

            }
        }
        public void logic()
        {
            int i;
            for (i = 1; i <=N; i++)
            {
                Console.WriteLine("2 * " + i + "=" + 2 * i);
            }
        }
    }
}