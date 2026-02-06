class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The numbers you entered are: " + number1 + " and " + number2);

        if (number1 > number2)
        {
            System.Console.WriteLine("The greater number is: " + number1);
        }
        else
        {
            System.Console.WriteLine("The greater number is: " + number2);
        }
    }
}