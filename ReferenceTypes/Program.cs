using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal,float,enum, boolean value types
            int a = 10;
            int b = 20;
            a = b;
            b = 100;
            Console.WriteLine("Sayı 1: " + a);

            //arrays, class, interface reference types

            
            int[] aC = new int[] {1,2,3};
            int[] bC = new int[] { 10, 20, 30 };

            aC = bC;
            bC[0] = 6789;
            Console.WriteLine("Sayılar[0]" + aC[0]);

        }
    }
}