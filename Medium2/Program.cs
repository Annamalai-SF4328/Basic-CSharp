using System;
namespace Medium2;
class Program
{
    public static void Main(string[] args)
    {
        double gl,tw,tl,bw,bl;
        gl=Convert.ToDouble(Console.ReadLine());
        tw=Convert.ToDouble(Console.ReadLine());
        tl=Convert.ToDouble(Console.ReadLine());
        bw=Convert.ToDouble(Console.ReadLine());
        bl=Convert.ToDouble(Console.ReadLine());
        double tn;
        double time;
        Calcu(gl,tw,tl,bw,bl,out tn,out time);
        Console.WriteLine($"Number of tiles needed {tn:F2}");
        Console.WriteLine($"Total time for changing {time:F1}");
    }
    static void Calcu(double gl,double tw,double tl,double bw,double bl, out double tn,out double time)
    {
        double ga=gl*gl;
        double ta=tw*tl;
        double ba=bw*bl;
        tn=Math.Round(((ga-ba)/ta),2);
        time=Math.Round((tn*0.2),1);
    }
}
