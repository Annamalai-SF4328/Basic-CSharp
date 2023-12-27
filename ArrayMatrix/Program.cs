using System;

namespace ArrayMatrix;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[9];
        for(int i=0; i<9; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int k=0;
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(arr[k]+" ");
                k++;
            }
            Console.WriteLine();
        }
    }
}