using System;

namespace Pascals_Triangle
{
    class pascalsTriangle
    {
        static void Main(string[] args)
        {
            int rowNumbers;
            int rowsAbove = 0;
            int rowsBelow = 0;

            System.Console.WriteLine("Pascal Triangle Program");
            System.Console.Write("Enter the number of rows: ");
            string inputRows = System.Console.ReadLine();
            
            if (Int32.TryParse(inputRows, out rowNumbers) == true)
            {
                if (rowNumbers > 25)
                {
                    System.Console.WriteLine("Invalid Input. Row greater than 25 is not allowed.");
                }
                else
                {
                    for (int count = 0; count < rowNumbers; count++)
                    {
                        int digits = 1;

                        for (int printer = 0; printer <= count; printer++)
                        {
                            rowsAbove += digits;
                            digits = digits * (count - printer) / (printer + 1);
                        }
                    }

                    int belowRowNumbers = rowNumbers + 1;
                    for(int count = 0; count < belowRowNumbers; count++)
                    {
                        int digits = 1;

                        for (int printer = 0; printer <= count; printer++)
                        {
                            rowsBelow += digits;
                            digits = digits * (count - printer) / (printer + 1);
                        }
                    }
                    System.Console.WriteLine("\nThe sum of numbers above row {0:#,0} is {1:#,0}", rowNumbers, rowsAbove);
                    System.Console.WriteLine("The sum numbers in row {0:#,0} is {1:#,0}", belowRowNumbers, rowsBelow+1);
                }

            }
            else 
            {
                System.Console.WriteLine("Invalid row input. Input must be a number.");
            }
        }
    }
}