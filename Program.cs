﻿using System;

namespace uri1006
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite a primeira nota: ");
            double A = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double B = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double C = Double.Parse(Console.ReadLine());
            A = A*2;
            B = B*3;
            C = C*5;
            double MEDIA = ((A+B+C)/10);

                Console.WriteLine("MEDIA = " +MEDIA.ToString("N1"));

        }
    }
}
