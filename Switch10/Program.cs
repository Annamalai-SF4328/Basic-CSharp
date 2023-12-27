using System;
using System.Diagnostics;
namespace Switch10;
class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string sw = Console.ReadLine();
        string sstr = Console.ReadLine();
        int index = str.IndexOf(sw);
        string res = str.Insert(index,sstr+" ");
        Console.WriteLine(res);
    }



    // public static void Main(string[] args)
    // {
    //     char ch = Convert.ToChar(Console.ReadLine());
    //     string res = Check(ch);
    //     Console.WriteLine($"\nThe character is {res}");
    // }
    // static string Check(char ch)
    // {
    //     switch(Char.ToLower(ch))
    //     {
    //         case >='a' and <='z':
    //             return "an alphabet";
    //         case >='0' and <='9':
    //             return "a digit";
    //         default:
    //             return "a special character";
    //     }
    // }
}