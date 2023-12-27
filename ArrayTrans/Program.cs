using System;
namespace ArrayTrans;
class Program
{
    public static void Main(string[] args)
    {
        int row = Convert.ToInt32(Console.ReadLine());
        int cln = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[row,cln];

        for(int i=0; i<row; i++)
        {
            for(int j=0;j<cln;j++)
            {
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        
        for(int i=0; i<cln; i++)
        {
            for(int j=0;j<row;j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}