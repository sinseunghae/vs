using System;
using System.IO;

namespace LeapYear
{
    class Program
    {
        static string textFile = @"D:\Study Files\2nd Year - 1st Sem\CCP 1103\VS - Text Files\factorialInputs.txt";

        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(textFile);
            string inputNumber;
            int number;

            Console.WriteLine("Factorial of a Number\n");

            while ((inputNumber = file.ReadLine()) != null)
            {
                if (Int32.TryParse(inputNumber, out number) == true)
                {
                    int output = 1;
                    if (number > 0)
                    {
                        for (int digits = number; digits > 0; digits--)
                        {
                            output *= digits;
                        }
                        Console.WriteLine("{0:#,0}! is {1:#,0}", number, output);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Negative input was detected.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Non-numeric was detected.");
                }
            }
            file.Close();
            Console.ReadKey();
        }
    }
}
