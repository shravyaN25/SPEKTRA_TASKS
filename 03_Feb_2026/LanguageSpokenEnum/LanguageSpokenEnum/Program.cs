class MainClass
{
    enum Country
    {
        India = 1,
        Australia,
        US,
        UK,
        China,
        Japan,
        Canada,
        Brazil,
        Spain
    }

    static void Main()
    {
        Console.WriteLine("For which Country You Want to Know Language");
        Console.WriteLine("1. India");
        Console.WriteLine("2. Australia");
        Console.WriteLine("3. US");
        Console.WriteLine("4. UK");
        Console.WriteLine("5. China");
        Console.WriteLine("6. Japan");
        Console.WriteLine("7. Canada");
        Console.WriteLine("8. Brazil");
        Console.WriteLine("9. Spain");

        Console.WriteLine("Please Enter your Choice:");
        int choice = int.Parse(Console.ReadLine());

        Country c = (Country)choice;

        switch (c)
        {
            case Country.India:
            case Country.Australia:
            case Country.US:
            case Country.UK:
                Console.WriteLine("Language spoken in {0} is English", code);
                break;

            case Country.China:
                Console.WriteLine("Language spoken in {0} is Chinese", code);
                break;

            case Country.Japan:
                Console.WriteLine("Language spoken in Japan is Japanese");
                break;
            case Country.Canada:
                Console.WriteLine("Language spoken in Canada is Canadian");
                break;

            case Country.Brazil:
                Console.WriteLine("Language spoken in Brazil is Portuguese");
                break;

            case Country.Spain:
                Console.WriteLine("Language spoken in Spain is Spanish");
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
