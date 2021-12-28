using System;
using System.Collections.Generic;
using System.Text;

namespace VowelCounter
{
    public class VowelCountingLogicClass
    {
        private static void UserStringInput()
        {
            Console.WriteLine("\nThis program will count the number of vowels of any sentence you input\n");
            Console.WriteLine("\nPlease enter a sentence below....");
            Console.Write("\nType Here: ");
        }

        private static int LetterCounter(string UserInputLower)
        {
            char[] charArray = UserInputLower.ToCharArray();
            int numOfSpaces = 0;
            int numOfLetters = 0;
            int totalLetters = 0;
            bool count = true;
            while (count == true)
            {
                foreach (char ch in charArray)
                {
                    switch (ch)
                    {
                        case (char)VowelEnums.a:
                            numOfLetters++;
                            break;

                        case (char)VowelEnums.e:
                            numOfLetters++;
                            break;

                        case (char)VowelEnums.i:
                            numOfLetters++;
                            break;

                        case (char)VowelEnums.o:
                            numOfLetters++;
                            break;

                        case (char)VowelEnums.u:
                            numOfLetters++;
                            break;

                        case ' ':
                            numOfSpaces++;
                            numOfLetters++;
                            break;
                        default:
                            numOfLetters++;
                            break;
                    }
                }
                if (numOfLetters == charArray.Length)
                {
                    count = false;
                }
                else
                {
                    break;
                }
            }
            totalLetters = numOfLetters - numOfSpaces;
            return totalLetters;
        }
        private static int VowelCounter(string UserInputLower)
        {
            char[] charArray = UserInputLower.ToCharArray();
            int numOfVowels = 0;
            int numOfLetters = 0;
            bool count = true;
            while (count == true)
            {
                foreach (char ch in charArray)
                {
                    switch (ch)
                    {
                        case (char)VowelEnums.a:
                            numOfVowels++;
                            numOfLetters++;
                            break;

                        case (char)VowelEnums.e:
                            numOfVowels++;
                            numOfLetters++;
                            break;

                        case (char)VowelEnums.i:
                            numOfVowels++;
                            numOfLetters++;
                            break;

                        case (char)VowelEnums.o:
                            numOfVowels++;
                            numOfLetters++;
                            break;

                        case (char)VowelEnums.u:
                            numOfVowels++;
                            numOfLetters++;
                            break;

                        default:
                            numOfLetters++;
                            break;
                    }
                }
                if (numOfLetters == charArray.Length)
                {
                    count = false;
                }
                else
                {
                    break;
                }
            }
            return numOfVowels;
        }
        private static void ResultOutput(int numOfVowels, int numOfLetters)
        {
            Console.WriteLine($"\n\nYour sentence contained {numOfLetters} letters.\n{numOfVowels} of those letters were vowels.");
        }
        public void VowelCountingEngine()
        {
            UserStringInput();
            string userInput = Console.ReadLine();
            string userInputLower = userInput.ToLower();
            int numOfVowels = VowelCounter(userInputLower);
            int numOfLetters = LetterCounter(userInputLower);
            ResultOutput(numOfVowels, numOfLetters);
        }
    }
}
