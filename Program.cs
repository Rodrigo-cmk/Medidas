using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {





          string medida;
          double metros, cm, km;

          Console.WriteLine();
          Console.WriteLine("--- Exercício Medidas ---");
          Console.WriteLine("Descreva um valor para que possa ser exibido de Metros a Centímetros e Kilômetros...");
          medida = Console.ReadLine(); 
          Console.WriteLine();
          
          metros = Convert.ToDouble(medida);
          cm = metros*100;
          km = metros/1000;
          Console.WriteLine();


          Console.WriteLine($"A medida em Centímetros é: {cm:N}");
          Console.WriteLine($"A medida em Kilômetros é: {km:N3}");






            















        }
    }
}
