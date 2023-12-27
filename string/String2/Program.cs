using System;
namespace String2;
class Program
{
    public static void Main(string[] args)
    {
        string str ="1.Chennai ,2.Trichy,3.Mumbai";
        string[] word=str.Split(',');
        foreach(string st in word)
        {
            Console.WriteLine(st);
        }
    }
}