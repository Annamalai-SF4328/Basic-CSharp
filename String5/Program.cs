using System;
namespace String5;
class Program
{
    public static void Main(string[] args)
    {
        string str1, str2;
        str1 = Console.ReadLine();
        str2 = Console.ReadLine();
        bool temp = Comp1(str1,str2);
        if(temp)
        {
            Console.WriteLine("The two strings are equal.");
        }
        else
        {
            Console.WriteLine("The two strings are not equal.");
        }
    }
    static bool Comp1(string str1, string str2)
    {
        if(str1==str2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}