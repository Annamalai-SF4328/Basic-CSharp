using System;

namespace StringAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main String : ");
            string lstr = Console.ReadLine();
            Console.WriteLine("String to be searched : ");
            string substr = Console.ReadLine();
            int count=0;
            int index = lstr.IndexOf(substr);
            while(index!=-1)
            {
                count++;
                index = lstr.IndexOf(substr,index+1);
            }
            Console.WriteLine("String searched count is "+count);
        }
    }
}
