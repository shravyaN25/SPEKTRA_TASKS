enum DaysOfWeek
    {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday

}
class MainClass
{
       static void Main()
    {
        DaysOfWeek day = DaysOfWeek.Wednesday;
        System.Console.WriteLine(day);
        Console.WriteLine((int)day);
        Console.WriteLine("Enter a day number (0-6):");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine((DaysOfWeek)x);
    }

}