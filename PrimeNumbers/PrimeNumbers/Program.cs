using System;
using System.IO;

namespace DivisibleByNine
{
    public class FileReadingUsingSplit
    {
        static string textFile = @"D:\Study Files\2nd Year\1st Sem\CCP 1103\VS - Text Files\primeInputs.txt";
        public static void Main(string[] args)
        {
            StreamReader file = new StreamReader(textFile);
            string line;
            int firstNumber;
            int secondNumber;
            int sum = 0;

            while ((line = file.ReadLine()) != null)
            {
                char[] delimiter = new char[] { ',' };
                string[] partsOfLine = line.Split(delimiter);

                if (partsOfLine.Length == 2)
                {
                    if (Int32.TryParse(partsOfLine[0], out firstNumber) == true)
                    {
                        if (Int32.TryParse(partsOfLine[1], out secondNumber) == true)
                        {
                            if (firstNumber < secondNumber)
                            {
                                Console.WriteLine("The prime numbers from {0:#,0} to {1:#,0}: ", firstNumber, secondNumber);
                                for (int counter = firstNumber; counter <= secondNumber; counter++)
                                {
                                    if (counter % 2 != 0 && counter % 5 !=0)
                                    {
                                        Console.Write("{0:#,0} ", counter);
                                    }
                                }
                                Console.WriteLine("\n");
                            }
                            else
                            {
                                Console.WriteLine("Invalid first input. It must be less than the second input.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid second number input.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid first number input.");
                    }
                }
                else
                {
                    Console.WriteLine("Input Error. Must have two inputs only in a set.");
                }

            }
            file.Close();
            Console.ReadKey();
        }
    }
}