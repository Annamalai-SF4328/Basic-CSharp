using System;
namespace Medium9;
class Program
{
    public static void Main(string[] args)
    {
        double ms=Convert.ToDouble(Console.ReadLine());
        int mon=Convert.ToInt32(Console.ReadLine());
        int year=Convert.ToInt32(Console.ReadLine());
        int lea=Convert.ToInt32(Console.ReadLine());
        int day=DateTime.DaysInMonth(year,mon);
        // Console.WriteLine(day);
        //int day=Calcu(year,mon);
        double ld=lea;
        double ds=ms/day;
        double ts=ms-ld;
        double ths=ts-(lea*ds);
        Console.WriteLine(Math.Round((ths),2));
    }
    static int Calcu(int year,int mon)
    {
        int wd=0;
        DateTime sd=new DateTime(year,mon,1);
        DateTime ed=sd.AddMonths(1).AddDays(-1);
        for(DateTime date=sd;date<=ed;date=date.AddDays(1))
        {
            if(date.DayOfWeek!=DayOfWeek.Saturday && date.DayOfWeek!=DayOfWeek.Sunday)
            {
                wd++;
            }
        }
        return wd;
    }
}