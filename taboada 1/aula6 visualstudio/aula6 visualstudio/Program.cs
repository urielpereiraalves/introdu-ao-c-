using System;

namespace aula6_visualstudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            for (int i = 1; i <= 20; i++) ;
            {
                Console.WriteLine($" posição {i} valor que deseija somar {valor}:");
                valor += int.Parse(Console.ReadLine());
            }
           Console.WriteLine($"somatótia: {valor}");
                
        }
    }
}
