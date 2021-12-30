using System;
using System.Collections.Generic;
using System.Text;

namespace VowelCounter
{
    public class VowelCounting
    {
        private static void UserStringInput()
        {
            Console.WriteLine("\nThis program will count the number of vowels of any sentence you input\n");
            Console.WriteLine("\nPlease enter a sentence below....");
            Console.Write("\nType Here: ");
        }
        
        private static int LetterCounter(string UserInputLower)
        {
            int numOfSpaces = 0;
            UserInputLower.Trim();
            int letters = UserInputLower.Trim().Length;

            foreach (char ch in UserInputLower)
            {
                if (ch == ' ')
                {
                    numOfSpaces++;
                }
            }
            int letterCount = letters - numOfSpaces;
            return letterCount;            
        }

        private static HashSet<char> VowelHash()
        {
            HashSet<char> vowels = new HashSet<char>()
            {'a', 'e', 'i', 'o', 'u'};            
            return vowels;
        }


        private static int VowelCounter(string UserInputLower, HashSet<char> vowels)
        {
            int vowelCount = 0;

            foreach (char ch in UserInputLower)
            {
                if (vowels.Contains(ch))
                {
                    vowelCount++;
                }
            }
            return vowelCount;                        
        }
       
        private static void ResultOutput(int numOfVowels, int numOfLetters)
        {
            Console.WriteLine($"\n\nYour sentence contained {numOfLetters} letters.\n{numOfVowels} of those letters were vowels.");
        }
        public void DisplayResults()
        {
            UserStringInput();
            string userInput = Console.ReadLine();
            string userInputLower = userInput.ToLower();
            HashSet<char> vowels = VowelHash();
            int numOfVowels = VowelCounter(userInputLower, vowels);
            int numOfLetters = LetterCounter(userInputLower);
            ResultOutput(numOfVowels, numOfLetters);
        }
    }
}
