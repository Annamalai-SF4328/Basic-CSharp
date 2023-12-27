using System;
namespace LoopAssignment;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        for(int i=0;i<10;i++)
        {
            int temp = Convert.ToInt32(Console.ReadLine());
            sum+=temp;
        }
        Console.WriteLine($"Sum : {sum}\nAverage : {sum/10}");
    }
}
