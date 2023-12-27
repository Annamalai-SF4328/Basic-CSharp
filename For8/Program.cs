using System;
namespace For7;
class Program
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        long sum = 0;
        long k =0;
        for(int i=1; i<=num;i++)
        {
            k =k*10 +1;
            sum += k;
        }
        Console.Write(sum);
    }
}
