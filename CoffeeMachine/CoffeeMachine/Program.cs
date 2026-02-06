class CoffeeMachine
{
    static void Main()
    {
        int cost = 0;
        int choice;

        Console.WriteLine("Select Coffee Size:");
        Console.WriteLine("1. Small");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Large");

        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                cost = 25;
                Console.WriteLine("Small coffee selected");
                break;

            case 2:
                cost = 25 + 15;
                Console.WriteLine("Medium coffee selected");
                break;

            case 3:
                cost = (25 + 15) + 10;
                Console.WriteLine("Large coffee selected");
                break;

            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        Console.WriteLine("Total cost = " + cost);
    }
}
