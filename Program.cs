﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double a;
            double b;
            double z;

            Console.Write("Informe o valor de x:");
            a = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor de y:");
            b = double.Parse(Console.ReadLine());

            z = Math.Pow(a, b);

            Console.WriteLine("a potencia é: {0}", z);
        }
    }
}
