using System;
namespace ArrayAssignment;
class Program
{
    public static void Main(string[] args)
    {
        int[] num = new int[5];

        for (int i = 0; i < 5; i++)
        {
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(num);

        Console.WriteLine("Sorted array : ");
        foreach (int j in num)
        {
            Console.Write(j+" ");
        }
    }
}