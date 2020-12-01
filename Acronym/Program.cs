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
            char firstLetter = userInput[0];

            for (int i = 0; i < userInput.Length; i++)
                {
                char findSpace = userInput[i];
                if (findSpace == ' ')
                    {
                    finalAcronym = userInput.Substring(i + 1, 1);
                    }
                }

            Console.WriteLine(firstLetter + finalAcronym);
        }
    }
}
