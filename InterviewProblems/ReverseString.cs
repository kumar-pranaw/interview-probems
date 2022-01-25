using System;

namespace InterviewProblems
{
    internal class ReverseString
    {
        public string ReverseTheCharacter(string value)
        {
            string reversedCharacter = String.Empty;
            if (value != null)
            {
                var splittedText = value.ToCharArray();
                for (int i = splittedText.Length - 1; i >=0; i--)
                {
                    reversedCharacter += splittedText[i];
                }
            }

            return reversedCharacter;
        }

        public string ReverseTheString(string value)
        {
            string reversedString = String.Empty;
            if (value != null)
            {
                var splitString = value.Split();
                for (int i = splitString.Length-1; i >=0; i--)
                {
                    reversedString += splitString[i]+" ";
                }
            }

            return reversedString;
        }
    }
}
