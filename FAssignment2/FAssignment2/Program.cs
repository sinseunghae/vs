using System;

namespace FAssignment2
{
    class DecimalToOctal
    {
        public static void Main(string[] args)
        {

            long decimalNumber;
            string octalNumber;

            DecimalToOctal octalConverter = new DecimalToOctal();

            Console.WriteLine("Decimal numbers to Binary numbers");
            Console.Write("Enter a binary number: ");

            string inputNumber = Console.ReadLine();

            if (long.TryParse(inputNumber, out decimalNumber) == true)
            {
                if (decimalNumber < 0)
                {
                    Console.WriteLine("Input error. {0:#} is a negative number, please input a valid number.", inputNumber);
                }
                else
                {
                    octalNumber = octalConverter.Conversion(decimalNumber);
                    Console.WriteLine("The equivalent value of {0:#,0} binary number in decimal number is {1:#,0}", inputNumber, octalNumber);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please input a valid number.");
            }
        }
        public string Conversion(long number)
        {
            string output = "";
            long[] octalValue = new long[999];
            long index = 1;

            long octalNum = number;
            while (octalNum != 0)
            {
                octalValue[index++] = octalNum % 8;
                octalNum /= 8;
            }

            for (long counter = index-1; counter > 0; counter--)
            {
                output += Convert.ToString(octalValue[counter]);
            }

            return output;
        }
    }
}
