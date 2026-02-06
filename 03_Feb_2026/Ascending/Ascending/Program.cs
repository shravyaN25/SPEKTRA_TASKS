class Program
{
    static void Main()
    {
        int a, b, c;

        Console.Write("Enter first number: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine("Ascending order:");

        if (a < b)
        {
            if (a < c)
            {
                // a is smallest
                if (b < c)
                    Console.WriteLine(a + " " + b + " " + c);
                else
                    Console.WriteLine(a + " " + c + " " + b);
            }
            else
            {
                // c is smallest
                Console.WriteLine(c + " " + a + " " + b);
            }
        }
        else
        {
            if (b < c)
            {
                // b is smallest
                if (a < c)
                    Console.WriteLine(b + " " + a + " " + c);
                else
                    Console.WriteLine(b + " " + c + " " + a);
            }
            else
            {
                // c is smallest
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
    }
}
