using System;

namespace Acronym
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase or group of words and press return. I will give you its acronym.");
            string userInput = Console.ReadLine();

            string finalAcronym = "";
            //TODO I'd like to find a way to eliminate the need for this variable
            char firstLetter = userInput[0];

            for (int i = 0; i < userInput.Length; i++)
                {
                //Do I need this char?
                char findSpace = userInput[i];
                string newLetter = "";
                if (findSpace == ' ')
                    {
                    newLetter = userInput.Substring(i + 1, 1);
                    finalAcronym = finalAcronym + newLetter;
                }
            }

            Console.WriteLine(firstLetter + finalAcronym);
        }
    }
}
