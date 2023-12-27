using System;
namespace Date10;
class Program
{
    public static void Main(string[] args)
    {
        bool temp = DateTime.TryParseExact(Console.ReadLine(),"MM/dd/yyyy",null, System.Globalization.DateTimeStyles.None, out DateTime date);
        if(date.Month >= 1 && date.Month <= 12)
        {
            string[] months=GetNameString(date.Month);
            for(int i=0;i<months.Length;i++)
            {
                Console.WriteLine(months[i]);
            }
        }
    }
    static string GetMonthName(int month)
    {
        return new DateTime(1,month,1).ToString("MMMM");
    }
    static string[] GetNameString(int date)
    {
        string[] months=new string[12];
        for(int i=0;i<12;i++)
        {
            int cm=(date+i-1)%12+1;
            months[i]=GetMonthName(cm);
        }
        return months;
    }
    // public static void Main(string[] args)
    // {
    //     int k;
    //     string[] mon=GetMonth(out k);
    //     for(int i=k;i<k+mon.Length;i++)
    //     {
    //         Console.WriteLine(mon[i]);
    //     }
    // }
    // static string[] GetMonth(out int k)
    // {
    //     bool temp = DateTime.TryParseExact(Console.ReadLine(),"MM/dd/yyyy",null, System.Globalization.DateTimeStyles.None, out DateTime date);
    //     int year=date.Year;
    //     k = date.Month;
    //     string[] mons=new string[12];
    //     for(int i=0;i<12;i++)
    //     {
    //         DateTime mondate=new DateTime(year,i+1,1);
    //         mons[i]=mondate.ToString("MMMM");
    //     }
    //     return mons;
    // }
}
