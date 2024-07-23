using System;

namespace Perfect_Number
{
    class PerfectNumber
    {
        static int Perfect(int number) 
        {
            int sum = 0;
            for (int divisors = 1; divisors < number; divisors++) 
            {
                if (number % divisors == 0) 
                {
                    sum += divisors;
                }
            }
            return sum;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            string number = Console.ReadLine();
            int digit;
            Int32.TryParse(number, out digit); 
            Console.WriteLine(PerfectNumber.Perfect(digit));

            if (PerfectNumber.Perfect(digit) == digit)
            {
                Console.WriteLine("The number is a perfect number.");
            }
            else 
            {
                Console.WriteLine("The number is not a perfect number.");
            }
        }
    }
}
