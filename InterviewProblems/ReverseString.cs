using System;

namespace InterviewProblems
{
    internal class ReverseString
    {
        public string ReverseTheString(string value)
        {
            string reversedString = String.Empty;
            if (value != null)
            {
                var splittedText = value.ToCharArray();
                for (int i = splittedText.Length - 1; i > - 1; i--)
                {
                    reversedString += splittedText[i];
                }
            }

            return reversedString;
        }
    }
}
