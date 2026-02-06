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
            case 3:
                cost = cost + 10;   // large = medium + 10
                goto case 2;

            case 2:
                cost = cost + 15;   // medium = small + 15
                goto case 1;

            case 1:
                cost = cost + 25;   // ONLY fixed price
                Console.WriteLine("Coffee selected");
                break;

            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        Console.WriteLine("Total cost = " + cost);
    }
}
