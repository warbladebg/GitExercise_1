using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "p - Power",
            "l - Logarithm"
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
    }
}
