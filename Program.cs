using System;
using System.Runtime.InteropServices;

namespace getstarted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"\nArch {RuntimeInformation.OSArchitecture}");
            Console.WriteLine($"\nOS {RuntimeInformation.OSDescription}");
            Console.WriteLine($"\nProcArch {RuntimeInformation.ProcessArchitecture}");

            Console.WriteLine("\nQual é o seu nome, mano?");
            var nome = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nOlá, {nome}, {date:d} às {date:t}");
            Console.WriteLine("\nAperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
