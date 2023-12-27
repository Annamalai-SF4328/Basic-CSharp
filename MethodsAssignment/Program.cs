using System;

namespace MethodsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                long num1, num2;
                Console.WriteLine("Enter two numbers : ");
                num1 = Convert.ToInt64(Console.ReadLine());
                num2 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Choose below one\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                    {    long res = Add(num1, num2);
                        Console.WriteLine(res);
                        break;
                    }
                    case 2:
                    {
                        long res1 = Sub(num1, num2);
                        Console.WriteLine(res1);
                        break;
                    }
                    case 3:
                    {
                        long res2 = Mul(num1, num2);
                        Console.WriteLine(res2);
                        break;
                    }
                    case 4:
                    { 
                        double res3 = Div(num1, num2);
                        Console.WriteLine(res3);
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid Operation Choice.");
                        break;
                    }
                }
                Console.WriteLine("If you want to continue enter yes.");
                string temp = Console.ReadLine();
                if(temp!="yes")
                {
                    break;
                }
            }while(true);
        }
        static long Add(long num1, long num2)
        {
            return num1+num2;
        }
        static long Sub(long num1, long num2)
        {
            return num1-num2;
        }
        static long Mul(long num1, long num2)
        {
            return num1*num2;
        }
        static double Div(long num1, long num2)
        {
            return (double)num1/num2;
        }
    }
}