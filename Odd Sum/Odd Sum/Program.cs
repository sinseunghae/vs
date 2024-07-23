using System;
using System.IO;

namespace Odd_Sum
{
    public class OddSum
    {
        static string textFile = @"D:\Study Files\2nd Year\1st Sem\CCP 1103\VS - Text Files\odd.txt";
        public static void Main(string[] args)
        {
            StreamReader file = new StreamReader(textFile);
            string line;
            int caseNumber;
            int firstNumber;
            int secondNumber;
            
            while ((line = file.ReadLine()) != null)
            {
                if (Int32.TryParse(line, out caseNumber) == true)
                {
                    if (caseNumber > 0)
                    {
                        int currentCase = 1;
                        while ((line = file.ReadLine()) != null && currentCase <= caseNumber)
                        {
                            char[] delimiter = new char[] { ',' };
                            string[] partsOfLine = line.Split(delimiter);
                            if (partsOfLine.Length == 2)
                            {
                                if (Int32.TryParse(partsOfLine[0], out firstNumber) == true)
                                {
                                    if (Int32.TryParse(partsOfLine[1], out secondNumber) == true)
                                    {
                                        if (firstNumber <= 100 && secondNumber <= 100)
                                        {
                                            if (firstNumber < secondNumber)
                                            {
                                                int totalSum = 0;
                                                for (int digit = firstNumber; digit <= secondNumber; digit++)
                                                {
                                                    if (digit % 2 != 0)
                                                    {
                                                        totalSum += digit;
                                                    }
                                                }
                                                Console.WriteLine("Case {0:#,0}: {1:#,0}", currentCase, totalSum);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Input Error, the first input {0:#,0} is greater than {1:#,0}.\n", firstNumber, secondNumber);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Inputs must be less than or equal to 100.\n")
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid second number input.\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid first number input.\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Input Error. Must have two inputs in a set.\n");
                            }
                            currentCase++;
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Zero or negative inputs are not allowed.\n");
                        break;
                    }         
                }
                else
                {
                    Console.WriteLine("Invalid input. Letters or special characters are not allowed.\n");
                }
            }
        }
    }
}