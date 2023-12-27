using System;
namespace For7;
class Program
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        
        for(int i=1; i<=num;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        
    }
}
