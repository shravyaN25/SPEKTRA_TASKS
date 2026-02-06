class CalculationApp
{
    static void Main()
    {
        int a;
        int b;
        int choice;

        System.Console.WriteLine("Enter first number");
        a = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Enter second number");
        b = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Press 1 for Add");
        System.Console.WriteLine("Press 2 for Subtract");
        System.Console.WriteLine("Press 3 for Multiply");
        System.Console.WriteLine("Press 4 for Divide");

        choice = int.Parse(System.Console.ReadLine());

        switch (choice)
        {
            case 1:
                System.Console.WriteLine(a + b);
                break;

            case 2:
                System.Console.WriteLine(a - b);
                break;

            case 3:
                System.Console.WriteLine(a * b);
                break;

            case 4:
                System.Console.WriteLine(a / b);
                break;

            default:
                System.Console.WriteLine("Invalid choice");
                break;
        }

        System.Console.ReadLine();
    }
}
