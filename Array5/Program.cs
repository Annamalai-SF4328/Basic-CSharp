﻿using System;

namespace Array5;

class Program
{
    public static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for(int i=0; i<size; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }  
        Array.Sort(arr);
        foreach(int j in arr)
        {
            Console.Write(j+" ");
        }
    }
}