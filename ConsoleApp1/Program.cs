using System;

class MainClass
{

    public static string SearchingChallenge(string str)
    {

        int stringLength = str.Length;
        int maxPalindromeStringLength = 0;
        int maxPalindromeStringStartIndex = 0;

        for (int i = 0; i < str.Length; i++)
        {
            int currentCharIndex = i;

            for (int lastCharIndex = stringLength - 1; lastCharIndex > currentCharIndex; lastCharIndex--)
            {
                bool isPalindrome = true;

                if (str[currentCharIndex] != str[lastCharIndex])
                {
                    continue;
                }

                for (int nextCharIndex = currentCharIndex + 1; nextCharIndex < lastCharIndex / 2; nextCharIndex++)
                {
                    if (str[nextCharIndex] != str[lastCharIndex - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    if (lastCharIndex + 1 - currentCharIndex > maxPalindromeStringLength)
                    {
                        maxPalindromeStringStartIndex = currentCharIndex;
                        maxPalindromeStringLength = lastCharIndex + 1 - currentCharIndex;
                    }
                }
                break;
            }
        }

        return str.Substring(maxPalindromeStringStartIndex, maxPalindromeStringLength);
        //return str;

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(SearchingChallenge("hellosannasmith"));
    }

}