﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main (string [] args)
        {
           Console.Clear();

           Console.WriteLine("Primeiro valor: ");
           float valor1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Segundo valor: ");
           float valor2 = float.Parse(Console.ReadLine());

           Console.WriteLine("");  

           float resultado = valor1 + valor2; 
           Console.WriteLine($"O resultado da soma é {resultado}");         

        }
    }
}
