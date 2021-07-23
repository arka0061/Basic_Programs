using System;

namespace Basic_Programs
{
    class Flip_Coin
    {
        public static double check;
        public static int count_heads = 0;
        public static int count_tails = 0;
        public static double result = 0.0;
       public static void Coin()
        {
            Console.WriteLine("Enter the number of times to flip a coin!");
            double number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Random random = new Random();
                check = random.NextDouble();
                if (check < 0.5)
                {
                    Console.WriteLine("TAILS");
                    count_tails++;

                }
                else
                {
                    Console.WriteLine("HEADS");
                    count_heads++;
                }
            }
            result = (count_heads / number) * 100.0;
            Console.WriteLine("Percentage of HEADS IS : " + result);
            result = (count_tails / number) * 100.0;
            Console.WriteLine("Percentage of TAILS IS : " + result);

        }
    }
}