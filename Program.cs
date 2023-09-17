using System;

namespace FibonacciBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci SequenciaFibonacci = new Fibonacci();
            int[] SF = SequenciaFibonacci.CalcularFibonacci();

            Console.WriteLine("A sequência de Fibonacci é: " + string.Join(", ", SF));
        }
    }
}