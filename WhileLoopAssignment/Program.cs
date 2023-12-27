using System;

namespace WhileLoopAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Program 1
            int i=2;
            while(i<25)
            {
                Console.WriteLine(i);
                i+=2;
            }

            // Program 2
            while(true)
            {
                int num;
                Console.WriteLine("Enter Integer number : ");
                bool temp = int.TryParse(Console.ReadLine(), out num);
                if(temp)
                {
                    Console.WriteLine(num);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input format. Please enter the input in number format");
                }
            }
        }
    }
}