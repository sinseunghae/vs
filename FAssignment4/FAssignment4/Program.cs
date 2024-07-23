using System;

namespace FAssignment4
{
    class CountTheCharactersTwo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Count The Characters V2");

            CountTheCharactersTwo count = new CountTheCharactersTwo();

            Console.Write("Enter a string: ");
            string stringInput = Console.ReadLine();

            if (stringInput != "")
            {
                for (int operation = 1; operation <= 6; operation++)
                {
                    if (operation == 1)
                    {
                        Console.WriteLine("Number of vowels: {0:#,0}", count.Counter(stringInput, operation));
                    }
                    else if (operation == 2)
                    {
                        Console.WriteLine("Number of consonants: {0:#,0}", count.Counter(stringInput, operation));
                    }
                    else if (operation == 3)
                    {
                        Console.WriteLine("Number of digits: {0:#,0}", count.Counter(stringInput, operation));
                    }
                    else if (operation == 4)
                    {
                        Console.WriteLine("Number of whitespaces: {0:#,0}", count.Counter(stringInput, operation));
                    }
                    else if (operation == 5)
                    {
                        Console.WriteLine("Number of special characters: {0:#,0}", count.Counter(stringInput, operation));
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
            char whitespace = ' ';
            int whitespaceCount = 0;
            int vowelCount = 0;
            int consonantCount = 0;
            int characterCount = 0;
            int digitCount = 0;
            int index = 0;

            while (index < wordLength)
            {
                if (input[index] >= 'A' && input[index] <= 'Z' || input[index] >= 'a' && input[index] <= 'z')
                {
                    if (input[index] == 'a' || input[index] == 'e' || input[index] == 'i' || input[index] == 'o' || input[index] == 'u')
                    {
                        vowelCount++;
                    }
                    else if (input[index] == 'A' || input[index] == 'E' || input[index] == 'I' || input[index] == 'O' || input[index] == 'U')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
                else if (input[index] == whitespace)
                {
                    whitespaceCount++;
                }
                else if (input[index] >= '0' && input[index] <= '9')
                {
                    digitCount++;
                }
                else
                {
                    characterCount++;
                }
                index++;
            }

            int total = index;
            if (mode == 1)
            {
                return Convert.ToString(vowelCount);
            }
            else if (mode == 2)
            {
                return Convert.ToString(consonantCount);
            }
            else if (mode == 3)
            {
                return Convert.ToString(digitCount);
            }
            else if (mode == 4)
            {
                return Convert.ToString(whitespaceCount);
            }
            else if (mode == 5)
            {
                return Convert.ToString(characterCount);
            }
            else
            {
                return Convert.ToString(total);
            }
        }
    }

}
