using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 5;
            double numero2 = 6;
            double numero3 = 4; 
            double numero4 = 3;
            double numero5 = 2;
            double soma = numero1 + numero2 + numero3 + numero4 + numero5;
            Console.WriteLine($"Os numeros digitados foram {numero1}, {numero2}, {numero3}, {numero4} e {numero5} e sua soma é {soma}.");
        }
    }
}