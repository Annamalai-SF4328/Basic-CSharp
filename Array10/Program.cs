using System;
namespace Array10;
class Program
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for(int i=0; i<size; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        } 
        foreach(int k in arr)
        {
            if(k==num)
            {
                Console.WriteLine("yes");
                break;
            }
        }
    }
}