namespace Fibonacci;
public class Fibonacci
{
    public int[] CalcularFibonacci()
    {
        int NumeroUm = 1;
        int NumeroDois = 0;
        int Soma = 0;

        int[] Sequencia = new int[21];

        for (int i = 0; i <= 20; i++)
        {
            Sequencia[i] = NumeroDois; // nº atual
            Soma = NumeroUm + NumeroDois;
            NumeroDois = NumeroUm;
            NumeroUm = Soma;
        }
        return Sequencia; // retorna array contendo a sequência
    }
}
