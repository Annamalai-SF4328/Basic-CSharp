using System;
namespace While8;
        public class Program
        {
            public static void Main(string[] args)
            {
                int num, k=0;
                num = Convert.ToInt32(Console.ReadLine());
                while(k<3)
                {
                    bool res = true;
                    int i = 2;
                    while(i<num/2)
                    {
                        if(num%i==0)
                        {
                            res = false;
                            break;
                        }
                        i++;
                    }
                    if(res)
                    {
                        Console.WriteLine(num);
                        k++;
                    }   
                    num++;                
                }
            }
        }
            
