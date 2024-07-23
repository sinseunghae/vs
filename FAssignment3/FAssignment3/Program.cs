
using System;

namespace FAssignment3
{
    class CountTheCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count The Characters");

            CountTheCharacters count = new CountTheCharacters();

            Console.Write("Enter a string: ");
            string stringInput = Console.ReadLine();

            if (stringInput != " ")
            {
                for (int operation = 1; operation <= 4; operation++)
                {
                    if (operation == 1)
                    {
                        Console.WriteLine("Letter count: {0:#,0}", count.Counter(stringInput, operation));
                    } 
                    else if (operation == 2)
                    {
                        Console.WriteLine("Number count: {0:#,0}", count.Counter(stringInput, operation));
                    }
                    else if (operation == 3)
                    {
                        Console.WriteLine("Special character count: {0:#,0}", count.Counter(stringInput, operation));
                    } 
                    else
                    {
                        Console.WriteLine("Total number of characters: {0:#,0}", count.Counter(stringInput, operation));
                    }
                }
            } 
            else
            {
                Console.WriteLine("Invalid input. There is no string.");
            }
        }
        public string Counter(string input, int mode)
        {   
            int wordLength = input.Length;
            int alphabets = 0;
            int characters = 0;
            int digits = 0;
            int index = 0;
            
            while (index < wordLength)
            {
                if (input[index] >= 'A' && input[index] <= 'Z' || input[index] >= 'a' && input[index] <= 'z')
                {
                    alphabets++;
                } 
                else if (input[index] >= '0' && input[index] <= '9')
                {
                    digits++;
                }
                else
                {
                    characters++;
                }
                index++;
            }

            int total = index;
            if (mode == 1)
            {   
                return Convert.ToString(alphabets);
            } 
            else if (mode == 2)
            {
                return Convert.ToString(digits);
            }
            else if (mode == 3)
            {
                return Convert.ToString(characters);
            }
            else
            {
                return Convert.ToString(total);
            }  
        }
    }
}
