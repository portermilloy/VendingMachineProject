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
                Console.WriteLine("6.) Tea");
                Console.WriteLine("7.) Coffee");
                Console.WriteLine("8.) Granola bars");
                Console.WriteLine("9.) water");
                Console.WriteLine("0.) Exit");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                Console.Write("What option would you like? (0-5) ");

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
                        Console.WriteLine("\nNow Vending a Bottle of Tea");
                        break;
                    case 7:
                        Console.WriteLine("\nNow Vending a cup of coffee");
                        break;
                    case 8:
                        Console.WriteLine("\nNow Vending a Granola bar");
                        break;
                    case 9:
                        Console.WriteLine("\nNow Vending a bottle of water");
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