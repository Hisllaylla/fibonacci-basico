namespace Fibonacci;

class Program
{
    static void Main()
    {
        Fibonacci fibonacci = new Fibonacci(); // Crie uma instância da classe Fibonacci
        int[] SF = fibonacci.CalcularFibonacci(); // Chame o método para calcular a sequência

        Console.WriteLine("A sequência de Fibonacci é: " + string.Join(", ", SF));
    }
};