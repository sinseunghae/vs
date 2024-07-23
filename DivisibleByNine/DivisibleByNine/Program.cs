using System;
using System.IO;

namespace DivisibleByNine
{
    public class FileReadingUsingSplit
    {
        static string textFile = @"D:\Study Files\2nd Year - 1st Sem\CCP 1103\VS - Text Files\inputs.txt";
        public static void Main(string[] args)
        {
            StreamReader file = new StreamReader(textFile);
            string line;
            int firstNumber;
            int secondNumber;
            int sum = 0;

            while ((line = file.ReadLine()) != null)
            {
                char[] delimiter = new char[] { ' ' };
                string[] partsOfLine = line.Split(delimiter);

                if (partsOfLine.Length == 2)
                {
                    if (Int32.TryParse(partsOfLine[0], out firstNumber) == true)
                    {
                        if (Int32.TryParse(partsOfLine[1], out secondNumber) == true)
                        {
                            if (firstNumber < secondNumber)
                            {
                                Console.WriteLine("The numbers from {0:#,0} to {1:#,0}, divisible by 9: ", firstNumber, secondNumber);
                                for (int counter = firstNumber; counter <= secondNumber; counter++)
                                {
                                    int divisible = counter % 9;

                                    if (divisible == 0)
                                    {
                                        Console.Write(counter + " ");
                                        sum += counter;
                                    }
                                }
                                Console.WriteLine("\nThe sum of all numbers divisible by 9, from {0:#,0} to {1:#,0} is {2:#,0}", firstNumber, secondNumber, sum);
                                Console.WriteLine();
                                sum = 0;
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