using System;
class Program
{

    static void Main(string[] args)
    {
        int mainChoice;

        do
        {
            Console.WriteLine("Welcome to the Pizza and Multiplication Table Program!");
            Console.WriteLine("Enter 1 to display multiplication tables");
            Console.WriteLine("Enter 2 to display pizza options");
            Console.WriteLine("Enter 3 to exit");
            Console.Write("Your choice: ");
            mainChoice = Convert.ToInt32(Console.ReadLine());

            switch (mainChoice)
            {
                case 1:
                    DisplayMultiplicationTables();
                    break;
                case 2:
                    DisplayPizzaOptions();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                    break;
            }
        } while (mainChoice != 3);
    }

    static void DisplayMultiplicationTables()
    {
        Console.WriteLine("Multiplication table (4x11)");
        for (int i = 1; i <= 4; i++)
        {
            Console.Write(i);
            for (int j = 0; j < 11; j++)
            {
                Console.Write("\t" + (i * j));
            }
            Console.WriteLine();
        }

        Random random = new Random();
        int randomRows = random.Next(4, 11);
        Console.WriteLine($"Multiplication table {randomRows}x9");

        for (int i = 1; i <= randomRows; i++)
        {
            Console.Write(i);
            for (int j = 0; j < 10; j++)
            {
                Console.Write("\t" + (i * j));
            }
            Console.WriteLine();
        }
    }

    static void DisplayPizzaOptions()
    {
        int choice;
        Random random = new Random();

        do
        {
            Console.WriteLine("Enter 1 to display a plain topping-less pizza slice");
            Console.WriteLine("Enter 2 to display cheese pizza slice");
            Console.WriteLine("Enter 3 to display pepperoni pizza slice");
            Console.WriteLine("Enter 4 to go back to the main menu");
            Console.Write("Your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayPlainPizza();
                    break;
                case 2:
                    DisplayCheesePizza(random);
                    break;
                case 3:
                    DisplayPepperoniPizza(random);
                    break;
                case 4:
                    Console.WriteLine("Returning to main menu...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter 1, 2, 3, or 4.");
                    break;
            }
        } while (choice != 4);
    }

    static void DisplayPlainPizza()
    {
        int rows = new Random().Next(8, 13); // Random rows between 8 and 12

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - i; j++)
            {
                Console.Write("* "); // Outline of the pizza
            }
            Console.WriteLine();
        }
    }

    static void DisplayCheesePizza(Random random)
    {
        int rows = random.Next(8, 13); // Random rows between 8 and 12

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - i; j++)
            {
                if (i == 0 || j == 0 || j == rows - i - 1) // Outline condition
                {
                    Console.Write("* "); // Outline of the pizza
                }
                else
                {
                    Console.Write("# "); // Cheese filling
                }
            }
            Console.WriteLine();
        }
    }

    static void DisplayPepperoniPizza(Random random)
    {
        int rows = random.Next(8, 13); // Random rows between 8 and 12

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - i; j++)
            {
                if (i == 0 || j == 0 || j == rows - i - 1) // Outline condition
                {
                    Console.Write("* "); // Outline of the pizza
                }
                else
                {
                    // Randomly place pepperonis among cheese
                    if (random.Next(0, 2) == 0) // 50% chance to place pepperoni
                    {
                        Console.Write("[] "); // Pepperoni
                    }
                    else
                    {
                        Console.Write("# "); // Cheese filling
                    }
                }
            }
            Console.WriteLine();
        }
    }
}