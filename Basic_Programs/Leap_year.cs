using System;

namespace Basic_Programs
{
    class Leap_year
    {
        public static int number;
       public static void year()
        {
            Leap_year obj = new Leap_year();
            Console.WriteLine("Welcome to leap Year Problem!");
            Console.WriteLine("Please input a 4 digit number!");
            number = Convert.ToInt32(Console.ReadLine());
            if ((number / 1000) <= 9 && (number / 1000) != 0)
            {
                obj.logic();
            }
            else
            {
                Console.WriteLine("Please Enter Correct Input!");
            }
        }
        public void logic()
        {
            if (((number % 4 == 0) && (number % 100 != 0)) || (number % 400 == 0))
            {
                Console.WriteLine("The year : " + number + " is a leap year");
            }
            else
            {
                Console.WriteLine("The year : " + number + " is not a leap year");
            }


        }
    }
}