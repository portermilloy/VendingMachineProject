using System.IO;
using System;
namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            string time = DateTime.Now.ToString("yyyy-MM-dd");

            // specify your path here or leave this blank if you just use 'bin' folder
            //string path = String.Format(@"", time);
            //string path = $"{time}";
            string path = "logs";

            string filename = "log.txt";

            // This checks that path is valid, directory exists and if not - creates one:
            if (!string.IsNullOrWhiteSpace(path) && !Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists($"{path}/{filename}"))
            {
                File.Create($"{path}/{filename}");
            }

            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Vending Machine");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1.) Candy Bar");
                Console.WriteLine("2.) Soda");
                Console.WriteLine("3.) Energy Drink");
                Console.WriteLine("4.) Chips");
                Console.WriteLine("5.) Gum");
                Console.WriteLine("6.) Veggie Sticks");
                Console.WriteLine("7.) Protein Shake");
                Console.WriteLine("8.) Mushroom Jerky");
                Console.WriteLine("9.) Rice Cakes");
                Console.WriteLine("10.) Fruit Bar");
                Console.WriteLine("0.) Exit");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                Console.Write("What option would you like? (0-10) ");

                int answer = Convert.ToInt32(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        // Source - https://stackoverflow.com/a
                        // Posted by Fredrik Mörk, modified by community. See post 'Timeline' for change history
                        // Retrieved 2026-01-21, License - CC BY-SA 2.5

                        File.AppendAllText($"{path}/{filename}", $"Added Candy Bar at {time}" + Environment.NewLine);

                        Console.WriteLine("\nNow Vending a Candy Bar.");
                        break;

                    case 2:

                        File.AppendAllText($"{path}/{filename}", $"Added Soda at {time}" + Environment.NewLine);
                        Console.WriteLine("\nNow Vending a Soda.");
                        break;

                    case 3:

                        File.AppendAllText($"{path}/{filename}", $"Added Energy Drink at {time}" + Environment.NewLine);
                        Console.WriteLine("\nNow Vending an Energy Drink.");
                        break;

                    case 4:

                        File.AppendAllText($"{path}/{filename}", $"Added Bag of Chips at {time}" + Environment.NewLine);
                        Console.WriteLine("\nNow Vending a Bag of Chips.");
                        break;

                    case 5:

                        File.AppendAllText($"{path}/{filename}", $"Added Package of Gum at {time}" + Environment.NewLine);
                        Console.WriteLine("\nNow Vending a Package of Gum");
                        break;

                    case 6:

                        File.AppendAllText($"{path}/{filename}", $"Added Veggie Sticks at {time}" + Environment.NewLine);
                        Console.WriteLine("\nNow Vending a Package of Veggie Sticks");
                        break;

                    case 7:

                        File.AppendAllText($"{path}/{filename}", $"Added Protein Shake at {time}" + Environment.NewLine);
                        Console.WriteLine("\nNow Vending a Protein Shake");
                        break;

                    case 8:

                        File.AppendAllText($"{path}/{filename}", $"Added Mushroom Jerky at {time}" + Environment.NewLine);
                        Console.WriteLine("\nNow Vending a delicious Mushroom Jerky!");
                        break;

                    case 9:

                        File.AppendAllText($"{path}/{filename}", $"Added Rice Cakes at {time}" + Environment.NewLine);
                        Console.WriteLine("\nNow Vending Rice Cakes");
                        break;

                    case 10:

                        File.AppendAllText($"{path}/{filename}", $"Added Fruit Bar at {time}" + Environment.NewLine);
                        Console.WriteLine("\nNow Vending a Fruit Bar");
                        break;

                    case 0:
                        Console.WriteLine("\nWalking away from the Vending Machine.");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid Option -- Please try again!");
                        break;
                }

                Console.WriteLine("\nPress any key to continue.");
                Console.ReadLine();
            }
        }
    }
}