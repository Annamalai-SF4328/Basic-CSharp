using System;
namespace Date9;
class Program
{
    public static void Main(string[] args)
    {
        DateTime dt1 = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
        DateTime dt2 = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
        TimeSpan di = dt2-dt1;
        Console.WriteLine(Math.(di.TotalMinutes));
    }
}
