﻿using System;

namespace RotateArray
{
    internal class Program
    {
        static void RotateLeft(int[] input)
        {
            int temp = input[0];

            for (int i = 0; i < input.Length - 1; i++)
            {
                input[i] = input[i + 1];
            }
            input[input.Length - 1] = temp;
        }

        static void RotateRight(int[] input)
        {

            int temp = input[input.Length - 1];

            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = temp;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            RotateLeft(arr);
            //RotateRight(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}
