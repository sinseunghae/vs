using System;
using System.IO;

namespace LeapYear
{
    class Program
    {
        static string textFile = @"D:\Study Files\2nd Year\1st Sem\CCP 1103\VS - Text Files\LeapYear.txt";
        
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(textFile);
            string line;
            int year;

            Console.WriteLine("Leap Year\n");

            while ((line = file.ReadLine()) != null) 
            {
                if (Int32.TryParse(line, out year) == true)
                {
                    if (year > 0)
                    {
                        if (year % 4 == 0)
                        {
                            if (year % 100 == 0)
                            {
                                if (year % 400 == 0)
                                {
                                    Console.WriteLine("{0:#0} is a leap year", year);
                                }
                                else
                                {
                                    Console.WriteLine("{0:#0} is not a leap year", year);
                                }
                            }
                            else
                            {
                                Console.WriteLine("{0:#0} is a leap year", year);
                            }
                        }
                        else
                        {
                            Console.WriteLine("{0:#0} is not a leap year", year);
                        }
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
