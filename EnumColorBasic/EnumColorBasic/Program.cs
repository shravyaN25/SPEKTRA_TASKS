enum Color
{
    Purple = 1,
    Red,
    Green,
    Blue,
    White
}

class MainClass
{
    static void Main()
    {
        Console.WriteLine("For which Color do you want to know the meaning?");
        Console.WriteLine("1: Purple\n2: Red\n3: Green\n4: Blue\n5: White");
        Console.WriteLine("Enter Your Color: ");

        int code = int.Parse(Console.ReadLine());
        Color c = (Color)code;

        switch (c)
        {
            case Color.Purple:
                Console.WriteLine(c+"is BTS Color");
                break;

            case Color.Red:
                Console.WriteLine(c + " is tooo hot color");
                break;

            case Color.Green:
                Console.WriteLine(c + " is eye soothing color");
                break;

            case Color.Blue:
                Console.WriteLine(c + " is official color");
                break;

            case Color.White:
                Console.WriteLine(c + " is a peaceful color");
                break;

            default:
                Console.WriteLine("Invalid color choice");
                break;
        }
    }
}
