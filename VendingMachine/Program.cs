namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

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
                        Console.WriteLine("\nNow Vending a Candy Bar.");
                        break;

                    case 2:
                        Console.WriteLine("\nNow Vending a Soda.");
                        break;

                    case 3:
                        Console.WriteLine("\nNow Vending an Energy Drink.");
                        break;

                    case 4:
                        Console.WriteLine("\nNow Vending a Bag of Chips.");
                        break;

                    case 5:
                        Console.WriteLine("\nNow Vending a Package of Gum");
                        break;

                    case 6:
                        Console.WriteLine("\nNow Vending a Package of Veggie Sticks");
                        break;

                    case 7:
                        Console.WriteLine("\nNow Vending a Protein Shake");
                        break;

                    case 8:
                        Console.WriteLine("\nNow Vending a delicious Mushroom Jerky!");
                        break;

                    case 9:
                        Console.WriteLine("\nNow Vending Rice Cakes");
                        break;

                    case 10:
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