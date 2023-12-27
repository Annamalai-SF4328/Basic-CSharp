using System;

namespace SwitchAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter two numbers : ");
            num1 =Convert.ToDouble(Console.ReadLine());
            num2 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operation char sign : ");
            char ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case '+':
                {
                    Console.WriteLine(num1+num2);
                    break;
                }
                case '-':
                {
                    Console.WriteLine(num1-num2);
                    break;
                }
                case '*':
                {
                    Console.WriteLine(num1*num2);
                    break;
                }
                case '/':
                {
                    Console.WriteLine(num1/num2);
                    break;
                }
                case '%':
                {
                    Console.WriteLine(num1%num2);
                    break;
                }
                default:
                {
                    Console.WriteLine("Operation is Invalid.");
                    break;
                }

            }
        }
    }
}