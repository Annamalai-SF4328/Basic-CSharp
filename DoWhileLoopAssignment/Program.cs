using System;
using System.Runtime.InteropServices;

namespace DoWhileLoopAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                string temp = (num1%2==0) ? "Even":"Odd";
                Console.WriteLine(temp);
                Console.WriteLine("If you want Continue enter Yes else enter No ");
                string option = Console.ReadLine();
                if(option=="No")
                {
                    break;
                }
                else if(option !="Yes")
                {
                    do
                    {
                        Console.WriteLine("provided input is wrong. so, Give valid input Yes or No.");
                        option = Console.ReadLine();
                    }while(option != "Yes" && option != "No");
                }
                if(option=="No")
                {
                    break;
                }
            }while(true);

        }
    }
}

