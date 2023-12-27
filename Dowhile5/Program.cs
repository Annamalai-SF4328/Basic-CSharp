using System;
namespace Dowhile5;
class Program
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] arm = Arm(num);
        foreach(int i in arm)
        {
            Console.WriteLine(i);
        }
    }
    static int[] Arm(int num)
    {
        int[] arr = new int[0];
        int count =0;
        int number=1;
        do
        {
            if(Isarm(number))
            {
                Array.Resize(ref arr,arr.Length+1);
                arr[count]=number;
                count++;
            }
            number++;
        }while(number<=num);
        return arr;
    }
    static bool Isarm(int number)
    {
        int ori = number;
        int dcount = (int)Math.Floor(Math.Log10(number)+1);
        int sum =0;
        while(number>0)
        {
            int digit=number%10;
            sum+=(int)Math.Pow(digit,dcount);
            number/=10;
        }
        return sum==ori;
    }
}
