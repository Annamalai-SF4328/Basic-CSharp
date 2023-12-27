using System;
namespace String6;
class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int vow=0,con=0;
        for(int i=0; i<str.Length; i++)
        {
            if(str[i]=='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u' || str[i]=='A' || str[i]=='E' || str[i]=='I' || str[i]=='O' || str[i]=='U')
            {
                vow++;
            }
            else if(str[i]!=' ')
            {
                con++;
            }
        }
        Console.WriteLine($"Total number of vowels: {vow}\nTotal number of consonants: {con}");
    }
}