using System;
namespace ArrayAdd;
class Program
{
    public static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[size,size];
        int[,] arr1 = new int[size,size];
        for(int i=0; i<size; i++)
        {
            for(int j=0;j<size;j++)
            {
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        for(int i=0; i<size; i++)
        {
            for(int j=0;j<size;j++)
            {
                arr1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        for(int i=0; i<size; i++)
        {
            for(int j=0;j<size;j++)
            {
                Console.Write(arr[i,j]+arr1[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}
