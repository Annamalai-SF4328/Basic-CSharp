using System;

namespace StringAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dat = new DateTime(2021,8,10,10,40,32);
            Console.WriteLine("Year : "+dat.Year);
            Console.WriteLine("Month : "+dat.Month);
            Console.WriteLine("Day : "+dat.Day);
            Console.WriteLine("Hours : "+dat.Hour);
            Console.WriteLine("Minutes : "+dat.Minute);
            Console.WriteLine("Seconds : "+dat.Second);

            string temp = dat.ToString("dd/MM/yyyy hh:mm:ss tt");
            string[] spl= temp.Split('/',' ',':');
            for(int i=spl.Length-1; i>=0; i--)
            {
                Console.Write(spl[i]+" ");
            }
            Console.WriteLine();
            bool Temp = DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null, System.Globalization.DateTimeStyles.None, out DateTime dat1); 
            if(Temp)
            {
                Console.WriteLine(dat1.Year);
                Console.WriteLine(dat1.Month);
                Console.WriteLine(dat1.Day);
            }
        }
    }
}