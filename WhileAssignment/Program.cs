using System;
namespace WhileAssignment;
class Program
{
    public static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Enter capital city of India : ");
            Console.WriteLine("1.chennai\n2.Delhi\n3.Mumbai\n4.Kolkata\nEnter Your Choice : ");
            int ch =Convert.ToInt32(Console.ReadLine());
            if(ch==2)
            {
                Console.WriteLine("Correct");
            }
            else{
                Console.WriteLine("Wrong");
            }
            Console.WriteLine("Do you want to continue press Y otherwise press N");
            char op = Convert.ToChar(Console.ReadLine());
            if(op=='Y')
            {
                continue;
            }
            else{
                break;
            }
        }
    }
}