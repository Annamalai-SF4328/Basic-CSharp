using System;
namespace Rps;
class Program
{
    public static void Main(string[] args)
    {
        char ch = Convert.ToChar(Console.ReadLine());
        char ch1 = Convert.ToChar(Console.ReadLine());
        if(ch == 'R' && ch1 == 'S')
        {
            Console.Write("Winner : R");
        }
        else if(ch == 'S' && ch1 == 'P')
        {
            Console.Write("Winner : S");
        }
        else if(ch == 'P' && ch1 == 'R')
        {
            Console.Write("Winner : P");
        }
        else if(ch == 'R' && ch1 == 'P')
        {
            Console.Write("Winner : R");
        }
        else if(ch == 'S' && ch1 == 'R')
        {
            Console.Write("Winner : S");
        }
        else if(ch == 'P' && ch1 == 'S')
        {
            Console.Write("Winner : P");
        }
        else
        {
            Console.Write("Draw : D");
        }
    }
}
