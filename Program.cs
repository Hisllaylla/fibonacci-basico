namespace Fibonacci;
class Program
{
    static void Main()
    {
        Fibonacci sequenciaFibonacci = new Fibonacci(); // Cria uma instância da classe Fibonacci
        int[] SF = sequenciaFibonacci.CalcularFibonacci(); // Invoca i método de cálculo

        Console.WriteLine("A sequência de Fibonacci é: " + string.Join(", ", SF));
    }
};