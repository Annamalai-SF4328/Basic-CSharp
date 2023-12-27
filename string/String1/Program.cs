using System;
namespace String1;
class Program
{
    public static void Main(string[] args)
    {

        string input = "syncfusion";
        Console.WriteLine("1.Odd char");
        for (int i = 0; i < input.Length; i += 2)
        {
            Console.Write(input[i]);
        }

        Console.WriteLine("\n2. Replace n with N");
        Console.WriteLine(input.Replace('n', 'N'));

        Console.WriteLine("3. Reverse String");
        char[] charArr = input.ToCharArray();
        Array.Reverse(charArr);
        string rev = new string(charArr);
        Console.WriteLine(rev);

        Console.WriteLine("4. Length of string is " + input.Length);

        Console.WriteLine("5. Enter First string and second string : ");
        string fstr = Console.ReadLine();
        string sstr = Console.ReadLine();
        if (fstr.Length >= 4 && sstr.Length >= 3)
        {
            Console.WriteLine(fstr.Substring(0, 4) + sstr.Substring(sstr.Length - 3));
        }
    }
}