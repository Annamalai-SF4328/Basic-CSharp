using System;
namespace DateTi;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. Current month of day: ");
        Console.WriteLine(DateTime.Now.ToString("MMMM"));

        Console.WriteLine("2. Previous 3 days from the Current date: ");
        DateTime Pre = DateTime.Now.AddDays(-3);
        Console.WriteLine(Pre.ToString("yyyy-MM-dd"));

        Console.WriteLine("3. 12 hours time of now followed by am, pm: ");
        Console.WriteLine(DateTime.Now.ToString("hh:mm tt"));
    }
}