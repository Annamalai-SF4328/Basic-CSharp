using System;
namespace Grade;
class Program
{
    public static void Main(string[] args)
    {
        char grade=Convert.ToChar(Console.ReadLine());
        if(grade=='A')
        {
            Console.WriteLine("Grade A denotes 9 Points.");
        }
        else if(grade=='B')
        {
            Console.WriteLine("Grade B denotes 8 Points.");
        }
        else if(grade=='C')
        {
            Console.WriteLine("Grade C denotes 7 Points.");
        }
        else if(grade=='D')
        {
            Console.WriteLine("Grade D denotes 6 Points.");
        }
        else{
            Console.WriteLine("This is not a valid Grade.");
        }
    }
}