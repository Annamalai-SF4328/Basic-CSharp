using System;
namespace For7;
class Program
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        for(int i=1; i<=num;i++)
        {
            sum += (double)1/i;
        }
        Console.Write(sum);
    }
}
