using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("tabuada!");
            Console.WriteLine("insira o numero que voce quer multiplicar:");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                int resultado = numero * x;
                Console.WriteLine($"{numero} X {x} = {resultado}");

            }
        }
        
        
    }
}
