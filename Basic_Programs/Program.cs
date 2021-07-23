using System;

namespace Basic_Programs
{
    class Program
    {
       public static int choice = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to 10 to run the Following programs!");         
            Console.WriteLine("Press 1 for Flip_Coin!");
            Console.WriteLine("Press 2 for Leap_Year!");
            Console.WriteLine("Press 3 for Power_Of_2!");
            Console.WriteLine("Press 4 for Harmonic_Number!");
            Console.WriteLine("Press 5 for Prime_Factor!");
            Console.WriteLine("Press 6 for Quotient_And_Remainder!");
            Console.WriteLine("Press 7 for Swap_Numbers!");
            Console.WriteLine("Press 8 for Even or Odd!");
            Console.WriteLine("Press 9 for Vowel_Or_Constant!");
            Console.WriteLine("Press 10 for Largest_Among_Three_Numbers!");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Flip_Coin");
                    Flip_Coin flip = new Flip_Coin();
                    Flip_Coin.Coin();
                    break;

                case 2:
                    Console.WriteLine("Leap Year!");
                    Leap_year yr = new Leap_year();
                    Leap_year.year();
                    break;
                case 3:
                    Console.WriteLine("Power of 2!");
                    Power_Of_2 obj = new Power_Of_2();
                    Power_Of_2.power();
                    break;
                case 4:
                    Console.WriteLine("Harmonic Number!");
                    Harmonic_Number harm = new Harmonic_Number();
                    Harmonic_Number.harmonic();
                    break;
                case 5:
                    Console.WriteLine("Prime Factors");
                    Factors prime = new Factors ();
                    Factors.factor();
                    break;

                case 6:
                    Console.WriteLine("Quotient and Remainder");
                    Quotient_and_Remainder quo = new Quotient_and_Remainder();
                    Quotient_and_Remainder.Quotient_and_Remainders();
                    break;
                case 7:
                    Console.WriteLine("Swap Two Numbers");
                    Swap_Number swp = new Swap_Number();
                    Swap_Number.swap();
                    break;
                    
                case 8:
                    Console.WriteLine("Even Or Odd");
                    Even_odd e = new Even_odd();
                    Even_odd.check();
                    break;
                case 9:
                    Console.WriteLine("Vowel Or Consonant");
                    Vowel_Consonant v = new Vowel_Consonant();
                    Vowel_Consonant.check();
                    break;
                case 10:
                    Console.WriteLine("Largest_Among_Three_Numbers");
                    Largest_Three_Numbers l = new Largest_Three_Numbers();
                    Largest_Three_Numbers.check();
                    break;
                default: Console.WriteLine("Wrong Input!");
                    break;

            }
        }
    }
}
