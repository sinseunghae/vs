using System;
using System.IO;

namespace CCP_1103
{
    public class FileTextWithSplit
    {
        static string textFile = @"D:\Study Files\2nd Year\1st Sem\CCP 1103\VS - Text Files\inputText.txt";
        public static void Main(string[] args)
        {
            StreamReader file = new StreamReader(textFile);
            string line;
            int firstNumber;
            int secondNumber;
            int sum;

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
                            sum = firstNumber + secondNumber;
                            Console.WriteLine("The sum of {0:#,0} and {1:#,0} is {2:#,0}.", firstNumber, secondNumber, sum);
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
