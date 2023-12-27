using System;

namespace ForLoopAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            long num1, num2, sum = 0;
            Console.WriteLine("Enter small number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter big number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            for(long i=num1; i<=num2; i++)
            {
                sum = sum + (i*i);
            }
            Console.WriteLine("Sum of square numbers are "+sum);
        }
    }
}
