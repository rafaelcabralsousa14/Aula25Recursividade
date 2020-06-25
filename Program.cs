using System;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade();
            Console.ForegroundColor = ConsoleColor.Red;
            rec.GerarSequenciaFibonacci(0,1,15);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine(rec.GerarFatorial(5));
            Console.ResetColor();
        }
    }
}
