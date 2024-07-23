using System;
using System.IO;

namespace OddSum
{
    public class FileReadingUsingSplit
    {
        static string textFile = @"D:\Study Files\2nd Year\1st Sem\CCP 1103\VS - Text Files\odd.txt";
        public static void Main(string[] args)
        {
            StreamReader file = new StreamReader(textFile);
            string cases;
            int firstNumber;
            int secondNumber;
            int sum = 0;

            while ((cases = file.ReadLine()) != null)
            {
                char[] delimiter = new char[] { ' ' };
                string[] partsOfLine = cases.Split(delimiter);

                if (partsOfLine.Length == 2)
                {
                    if (Int32.TryParse(partsOfLine[0], out firstNumber) == true)
                    {
                        if (Int32.TryParse(partsOfLine[1], out secondNumber) == true)
                        {
                            if (firstNumber <= 100 && secondNumber <= 100)
                            {
                                if (firstNumber > 0 && secondNumber > 0)
                                {
                                    if (firstNumber < secondNumber)
                                    {
                                        Console.WriteLine("The odd numbers from {0:#,0} to {1:#,0}: ", firstNumber, secondNumber);
                                        for (int counter = firstNumber; counter <= secondNumber; counter++)
                                        {
                                            if (counter % 2 != 0)
                                            {
                                                Console.Write("{0:#,0} ", counter);
                                                sum += counter;
                                            }
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("The sum of odd numbers from {0:#,0} to {1:#,0} is {2:#,0}", firstNumber, secondNumber, sum);
                                        Console.WriteLine();
                                        sum = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid first input. It must be less than the second input. \n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Zero or negative input is not allowed. \n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Inputs must be less than or equal to 100. \n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid second number input. \n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid first number input. \n");
                    }
                }
                else
                {
                    Console.WriteLine("Input Error. Must have two inputs only in a set. \n");
                }
            }
            file.Close();
            Console.ReadKey();
        }
    }
}