class MainClass
{
    static void Main(string[] args)
    {

        int X, Y;
        System.Console.WriteLine("Enter first number: ");
        X= int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Enter second number: ");
        Y= int.Parse(System.Console.ReadLine());

        int Sum = X + Y;
        System.Console.Write("The sum of {0} and {1} is: {2}", X, Y, Sum);
        System.Console.ReadLine();
    }
}


