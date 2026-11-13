using System;
using System.Numerics;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "p - Power",
            "l - Logarithm",
            "f - Sum of two factorials"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void Power(double a, double b)
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
        }

        public static void Logarithm(double a, double b)
        {
            if (a <= 0 || b <= 0 || b == 1)
            {
                Console.WriteLine("Logarithm needs a > 0 and a base b > 0, b != 1.");
                return;
            }

            Console.WriteLine($"log{b}({a}) = {Math.Log(a, b)}");
        }

        public static void FactorialsSum(double a, double b)
        {
            if (!IsValidFactorialArgument(a) || !IsValidFactorialArgument(b))
            {
                Console.WriteLine("Factorial needs whole numbers from 0 to 1000.");
                return;
            }

            Console.WriteLine($"{a}! + {b}! = {Factorial((int)a) + Factorial((int)b)}");
        }

        private static bool IsValidFactorialArgument(double n)
        {
            return n >= 0 && n <= 1000 && n == Math.Floor(n);
        }

        private static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
