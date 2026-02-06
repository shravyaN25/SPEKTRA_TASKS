class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter starting number:");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter ending number:");
        int end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine(i + "*" + j + "=" + (i * j));
            }
            Console.WriteLine("----------------------");
        }
    }
}
