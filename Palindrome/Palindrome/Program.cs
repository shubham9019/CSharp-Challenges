using System;

namespace Palindrome
{
    class Program
    {
        static (bool, int) IsPalindrome(string thestr)
        {
            string teststr;
            teststr = thestr.ToUpper();
            var sb = new System.Text.StringBuilder();
            foreach (char c in teststr)
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }
            teststr = sb.ToString();
            int i = 0, j = teststr.Length - 1;
            while (i <= j)
            {
                if (teststr[i] != teststr[j])
                {
                    return (false, 0);
                }
                i++;
                j--;
            }
            return (true, thestr.Length);
        }
        static void Main(string[] args)
        {
            string inputstr = "";
            (bool b, int l) result;
            Console.WriteLine("Enter a string:");

            while (inputstr != "exit")
            {
                inputstr = Console.ReadLine();
                if (inputstr != "exit")
                {
                    result = IsPalindrome(inputstr);
                    Console.WriteLine($"Palindrome: {result.b}, Length: {result.l}");
                }
            }
            Console.ReadLine();
        }
    }
}
