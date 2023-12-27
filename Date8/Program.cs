using System;
namespace Date8;
class Program
{
    public static void Main(string[] args)
    {
        int month=Convert.ToInt32(Console.ReadLine());
        int year =Convert.ToInt32(Console.ReadLine());
        int ds=500;
        int nod=GetNumberOfDays(year,month);
        double ms=Calcu(nod,ds);
        Console.WriteLine(ms);
    }
    static int GetNumberOfDays(int year,int month)
    {
        return DateTime.DaysInMonth(year,month);
    }
    static double Calcu(int nod, int ds)
    {
        return nod*ds;
    }
    static string GetMonthName(int month)
    {
        return new DateTime(1,month,1).ToString("MMMM");
    }
}