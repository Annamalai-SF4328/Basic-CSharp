using System;
namespace Array4;
class Program
{
    public static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        for(int i=0; i<size; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        } 
        
        Console.Write("Odd Numbers : ");
        foreach(int i in arr)
        {
            if(i%2!=0)
            {
                Console.Write(i+" ");
            }
        }

        Console.WriteLine();
        Console.Write("Even Numbers : ");
        foreach(int i in arr)
        {
            if(i%2==0)
            {
                Console.Write(i+" ");
            }
        }
    }
}
