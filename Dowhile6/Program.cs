using System;
namespace Dowhile6;
class Program
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        int i=1;
        do
        {
            sum += (double)1/i;
            i++;
        }while(i<=num);
        Console.Write(sum);
    }
}
