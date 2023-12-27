using System;

namespace ArrayAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] names = new string[5]{"Mani", "Ganesh", "Venkat", "Suresh", "Annamalai"}; 
            for(int i=0; i<names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("Enter name to search in array : ");
            string name = Console.ReadLine();
            string k="yes";
            for(int i=0; i<names.Length; i++)
            {
                if(name==names[i])
                {
                    Console.WriteLine($"The {name} is present in array at index {i}");
                    k="no";
                }
            }
            if(k=="yes")
                {
                    Console.WriteLine("The name is not present in array");
                }
            foreach(string name1 in names)
            {
                if(name1==name)
                {
                    Console.WriteLine("The name is present in array");
                }
            }
            if(k=="yes")
            {
                Console.WriteLine("The name is not present in array");
            }
        }
    }
}