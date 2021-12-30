using System;
using System.Text;

namespace ReverseEachWord
{
    internal class Program
    {
        static String ReverseEachWord(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();
            String[] arr = input.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(Reverse(arr[i]));
                if (i != arr.Length - 1)
                {
                    result.Append(" ");
                }
            }

            return result.ToString();
        }

        static String Reverse(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            String temp = "";
            for (int i = 0;i < input.Length; i++)
            {
                temp = input[i] + temp;
            }
            
            return temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Hello world"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("abc 234 Asc"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
        }
    }
}
