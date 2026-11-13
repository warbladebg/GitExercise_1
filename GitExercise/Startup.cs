using System;

namespace GitExercise
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string('-', 15));

            while (true)
            {
                Console.WriteLine("Choose one from the listed options:");
                foreach (string option in OptionsManager.OptionsList)
                {
                    Console.WriteLine($"\t{option}");
                }

                Console.Write("Option: ");
                string choice = Console.ReadLine();

                if (choice == "e")
                {
                    break;
                }

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                switch (choice)
                {
                    case "a":
                        OptionsManager.Add(a, b);
                        break;
                    case "s":
                        OptionsManager.Subtract(a, b);
                        break;
                    case "m":
                        OptionsManager.Multiply(a, b);
                        break;
                    case "r":
                        OptionsManager.DivideRemainder(a, b);
                        break;
                    default:
                        Console.WriteLine("Unknown option.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Pres any key to close the app...");
            Console.ReadKey(true);
        }
    }
}
