using System;
namespace ArrayAssignment1;
class Program
{
    public static void Main(string[] args)
    {
        int[] num = new int[10];

        for (int i = 0; i < 10; i++)
        {
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(num);

        Console.WriteLine("Sorted array Odd elements : ");
        foreach (int j in num)
        {
            if(j%2!=0)
            {
                Console.Write(j+" ");
            }            
        }
        Console.WriteLine();
        Console.WriteLine("Sorted array Even elements : ");
        foreach (int j in num)
        {
            if(j%2==0)
            {
                Console.Write(j+" ");
            }            
        }
    }
}